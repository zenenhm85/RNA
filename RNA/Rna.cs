using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GlpkSharp;
using System.Globalization;
using Hydra;
namespace RNA
{
    public partial class Rna : Plantilla
    {
        public Rna()
        {
            InitializeComponent();
        }
        
        public static string objetive = "";
        Read readsbml;
        static public Sbml sbml;
        public static MakeFba makefba;
        public static OptimisationDirection pd;
        public static Setup_Constraints sc;

        public static string reactionoptimize;

        static bool results;

        public static int Funcion_obj;
        public static double z;
       

        static PointF[] pointresult;

        public static bool Result
        {
            get { return results; }
        }
        public static PointF[] PointResult
        {
            get { return pointresult; }
        }
        private void Rna_Load(object sender, EventArgs e)
        {
            fileTextBox.Text = Principal.FileAddres;
            reactionObjetiveComboBox.Text = Principal.objetivefuntion;
            readsbml = new Read();
            results = false;

            sbml = Principal.mysbml;


            foreach (Reaction item in sbml.ListReaction)
            {
                reactionObjetiveComboBox.Items.Add(item.Id);
                comboconstrain.Items.Add(item.Id);
                comboreactionexchange.Items.Add(item.Id);
            }
            foreach (Specie item in sbml.ListSpecie)
            {
                combometabolites.Items.Add(item.Id);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Principal.mod.Close();
            Close();
           
        }

        private void reactionObjetiveComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Reaction item in sbml.ListReaction)
            {
                if (item.Id == reactionObjetiveComboBox.Text)
                {
                    reactionTextBox.Text = item.Id;

                    break;
                }

            }
        }

        private void comboconstrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboconstrain.Text != reactionObjetiveComboBox.Text)
            {
                foreach (Reaction item in sbml.ListReaction)
                {
                    if (item.Id == comboconstrain.Text)
                    {
                        lowertextBox1.Text = item.LowerBound.ToString();
                        uppertextBox2.Text = item.UpperBound.ToString();
                        isReversibleTextBox.Text = item.Reversible.ToString();
                        break;
                    }

                }
            }
            else
            {

                DialogResult dr = MessageBox.Show("The objective function must be not configured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (dr == DialogResult.OK)
                {
                    comboconstrain.ResetText();
                    comboconstrain.SelectedIndex = -1;
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (comboconstrain.Text.Length > 0)
            {
                if (Sbml.There(comboconstrain, comboconstrain.Text))
                {
                    if (isReversibleTextBox.Text == "False")
                    {
                        if (double.Parse(lowertextBox1.Text, CultureInfo.InvariantCulture.NumberFormat) < 0)
                        {
                            MessageBox.Show("This reaction is irreversible, the Lower Bound must be less than zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            foreach (Reaction item in sbml.ListReaction)
                            {
                                if (item.Id == comboconstrain.Text)
                                {

                                    item.LowerBound = double.Parse(lowertextBox1.Text, CultureInfo.InvariantCulture.NumberFormat);
                                    item.UpperBound = double.Parse(uppertextBox2.Text, CultureInfo.InvariantCulture.NumberFormat);
                                    Principal.mysbml = sbml;
                                    if (!Principal.txt)
                                    {
                                        Read red = new Read();
                                        red.ActualizarRestricciones(Principal.doc, comboconstrain.Text.ToLower(), lowertextBox1.Text, uppertextBox2.Text);
                                    }
                                    MessageBox.Show("Update!!!!!!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;

                                }

                            }
                        }
                    }
                    else
                    {
                        foreach (Reaction item in sbml.ListReaction)
                        {
                            if (item.Id == comboconstrain.Text)
                            {

                                item.LowerBound = double.Parse(lowertextBox1.Text, CultureInfo.InvariantCulture.NumberFormat);
                                item.UpperBound = double.Parse(uppertextBox2.Text, CultureInfo.InvariantCulture.NumberFormat);
                                Principal.mysbml = sbml;
                                if (!Principal.txt)
                                {
                                    Read red = new Read();
                                    red.ActualizarRestricciones(Principal.doc, comboconstrain.Text.ToLower(), lowertextBox1.Text, uppertextBox2.Text);
                                }
                                MessageBox.Show("Update!!!!!!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Not exist a reaction with this name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select the reaction to be configured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (reactionObjetiveComboBox.Text.Length > 0 && comboreactionexchange.Text.Length > 0)
            {
                if (Sbml.There(reactionObjetiveComboBox, reactionObjetiveComboBox.Text) && Sbml.There(comboreactionexchange, comboreactionexchange.Text))
                {
                    if ((aNumericUpDown.Value != bNumericUpDown.Value) && (aNumericUpDown.Value < bNumericUpDown.Value))
                    {
                        makefba = new MakeFba();

                        int i = 0;

                        bool find = false;

                        foreach (Reaction item in sbml.ListReaction)
                        {
                            if (item.Id == reactionObjetiveComboBox.Text)
                            {
                                reactionoptimize = reactionObjetiveComboBox.Text;

                                find = true;

                                break;
                            }
                            i++;
                        }
                        if (find)
                        {


                            if (radiomax.Checked)
                            {
                                pd = OptimisationDirection.MAXIMISE;
                            }
                            else
                            {
                                pd = OptimisationDirection.MINIMISE;
                            }

                            pointresult = makefba.Rna(sbml, i, pd, (int)aNumericUpDown.Value, (int)bNumericUpDown.Value, comboreactionexchange.Text);



                            resultlist.Items.Clear();

                            string[] str;

                            ListViewItem list;


                            for (int k = 0; k < pointresult.Length; k++)
                            {
                                int kaux = k + 1;
                                str = new string[3] { kaux.ToString(), pointresult[k].X.ToString(), pointresult[k].Y.ToString() };

                                list = new ListViewItem(str);
                                resultlist.Items.Add(list);
                            }
                            results = true;
                            button3.Enabled = true;


                        }
                        else
                        {
                            results = false;
                            button3.Enabled = false;
                            MessageBox.Show("This reaction not exist in the model", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The values of A and B must be different, and A less than B", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else 
                {
                    MessageBox.Show("Select the objective functions to optimize and to be varied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Select the objective functions to optimize and to be varied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboreactionexchange_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics grf = new Graphics();
            grf.MdiParent = Principal.ActiveForm;
            grf.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (combometabolites.Text.Length > 0)
            {
                if (Sbml.There(combometabolites, combometabolites.Text))
                {
                    sbml.AgregaraMetabolitosExternos(combometabolites.Text);
                    if (!Principal.txt)
                    {
                        Read read = new Read();
                        read.ActualizarBoundaryCondition(Principal.doc, combometabolites.Text.ToLower());
                    }
                    // Principal.doc.PreserveWhitespace = true;


                    combometabolites.Items.Remove(combometabolites.Text);
                    Principal.mysbml = sbml;
                    MessageBox.Show("Correctly Converted!!!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("not exist a metabolite with this name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Select the metabolite to be removed of the internal metabolites", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (reactionObjetiveComboBox.Text.Length == 0)
            {
                MessageBox.Show("Select the function to optimize", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Sbml.There(reactionObjetiveComboBox, reactionObjetiveComboBox.Text))
                {
                    Principal.objetivefuntion = reactionObjetiveComboBox.Text;
                    Principal.yaabriconstraint = true;
                    sc = new Setup_Constraints();
                    sc.MdiParent = Principal.ActiveForm;
                    objetive = reactionObjetiveComboBox.Text;
                    this.Close();
                    sc.Show();
                }
                else
                {
                    MessageBox.Show("This reaction not exist in the model", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lowertextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '-' || char.IsControl(e.KeyChar) || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void uppertextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '-' || char.IsControl(e.KeyChar) || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (results)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {


                    makefba.SaveResulRNA(sbml, saveFileDialog1.FileName, pd, reactionoptimize,pointresult);
                    MessageBox.Show("Correctly Saved!!!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Not exist a result that save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
