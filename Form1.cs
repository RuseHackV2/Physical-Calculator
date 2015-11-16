using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Physical_Calculator___Eclips3
{
    public partial class formPC : Form
    {
        public formPC()
        {
            InitializeComponent();         
        }

        private void Clear()
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            lblResult.Text = "";
        }

        private void changeFormula(string[] array0)
        {
            cbxFormula.Items.Clear();
            for (int i = 0; i < array0.Length; i++)
            {
                cbxFormula.Items.Add(array0[i]);
            }
        }

        private void changeMagnitude(string[] array0)
        {
            cbxMagnitude.Items.Clear();
            for (int i = 0; i < array0.Length; i++)
            {
                cbxMagnitude.Items.Add(array0[i]);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblResult.Visible = true;
            switch (cbxField.SelectedIndex)
            {
                case 0://case 1
                    {
                        double f, m1, m2, r, gamma;
                        gamma = 6.674e-11;
                        switch (cbxFormula.SelectedIndex)
                        {
                            case 0://case 1.1
                                {
                                    switch (cbxMagnitude.SelectedIndex)
                                    {
                                        case 0://case 1.1.1
                                            {
                                                try
                                                {
                                                    m1 = Convert.ToDouble(txt1.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    m1 = 1.0;
                                                }
                                                try
                                                {
                                                    m2 = Convert.ToDouble(txt2.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    m2 = 1.0;
                                                }
                                                try
                                                {
                                                    r = Convert.ToDouble(txt3.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    r = 1.0;
                                                }
                                                f = (gamma * m1 * m2 / Math.Pow(r, 2));
                                                lblResult.Text = "Сила на привличане F е\n" + f.ToString("0.0000") + " нютона(N).";
                                            }; break;
                                        case 1://case 1.1.2
                                            {
                                                try
                                                {
                                                    f = Convert.ToDouble(txt1.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    f = 1.0;
                                                }
                                                try
                                                {
                                                    m2 = Convert.ToDouble(txt2.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    m2 = 1.0;
                                                }
                                                try
                                                {
                                                    r = Convert.ToDouble(txt3.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    r = 1.0;
                                                }
                                                m1 = (f * Math.Pow(r, 2) / (gamma * m2));
                                                lblResult.Text = "Масата на първото тяло m₁ е\n" + m1.ToString("0.0000") + " килограма(kg).";
                                                lblResult.Visible = true;
                                            }; break;
                                        case 2://case 1.1.3
                                            {
                                                try
                                                {
                                                    f = Convert.ToDouble(txt1.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    f = 1.0;
                                                }
                                                try
                                                {
                                                    m1 = Convert.ToDouble(txt2.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    m1 = 1.0;
                                                }
                                                try
                                                {
                                                    r = Convert.ToDouble(txt3.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    r = 1.0;
                                                }
                                                m2 = (f * Math.Pow(r, 2) / (gamma * m1));
                                                lblResult.Text = "Масата на второто тяло m₂ е\n" + m2.ToString("0.0000") + " килограма(kg).";
                                            }; break;
                                        case 3://case 1.1.4
                                            {
                                                try
                                                {
                                                    f = Convert.ToDouble(txt1.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    f = 1.0;
                                                }
                                                try
                                                {
                                                    m1 = Convert.ToDouble(txt2.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    m1 = 1.0;
                                                }
                                                try
                                                {
                                                    m2 = Convert.ToDouble(txt3.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    m2 = 1.0;
                                                }
                                                r = Math.Sqrt(gamma * m1 * m2 / f);
                                                lblResult.Text = "Разстояние между телата R е\n" + r.ToString("0.0000") + " метра(m).";
                                            }; break;//end of case 1.1.4
                                    }; break;
                                }; //end of case 1.1
                            case 1://case 1.2
                                {
                                    double ro, v, g;
                                    g = 9.80665;
                                    switch (cbxMagnitude.SelectedIndex)
                                    {
                                        case 0://case 1.2.1
                                            {
                                                try
                                                {
                                                    ro = Convert.ToDouble(txt1.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    ro = 1.0;
                                                }
                                                try
                                                {
                                                    v = Convert.ToDouble(txt2.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    v = 1.0;
                                                }
                                                f = ro * v * g;
                                                lblResult.Text = "Архимедова сила F е\n" + f.ToString("0.0000") + " нютона(N).";
                                            }; break;
                                        case 1://case 1.2.2
                                            {
                                                try
                                                {
                                                    f = Convert.ToDouble(txt1.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    f = 1.0;
                                                }
                                                try
                                                {
                                                    v = Convert.ToDouble(txt2.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    v = 1.0;
                                                }
                                                ro = f / (v * g);
                                                lblResult.Text = "Плътността ρ е\n" + ro.ToString("0.0000") + " килограма на кубичен метър(kg/m³).";
                                            }; break;
                                        case 2://case 1.2.3
                                            {
                                                try
                                                {
                                                    f = Convert.ToDouble(txt1.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    f = 1.0;
                                                }
                                                try
                                                {
                                                    ro = Convert.ToDouble(txt2.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    ro = 1.0;
                                                }
                                                v = f / (ro * g);
                                                lblResult.Text = "Обем на потопената част V е\n" + ro.ToString("0.0000") + " кубични метра(m³).";
                                            }; break;//end of case 1.2.3
                                    }
                                }; break;//end of case 1.2
                            case 2://case 1.3
                                {
                                    double v1, s1, v2, s2;
                                    switch (cbxMagnitude.SelectedIndex)
                                    {
                                        case 0://case1.3.1
                                            {
                                                try
                                                {
                                                    s1 = Convert.ToDouble(txt1.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    s1 = 1.0;
                                                }
                                                try
                                                {
                                                    v2 = Convert.ToDouble(txt2.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    v2 = 1.0;
                                                }
                                                try
                                                {
                                                    s2 = Convert.ToDouble(txt3.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    s2 = 1.0;
                                                }
                                                v1 = v2 * s2 / s1;
                                                lblResult.Text = "Скорост на флуида v₁ в т.1 е\n" + v1.ToString("0.0000") + " метра в секунда(m/s).";
                                            }; break;
                                        case 1://case 1.3.2
                                            {
                                                try
                                                {
                                                    v1 = Convert.ToDouble(txt1.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    v1 = 1.0;
                                                }
                                                try
                                                {
                                                    v2 = Convert.ToDouble(txt2.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    v2 = 1.0;
                                                }
                                                try
                                                {
                                                    s2 = Convert.ToDouble(txt3.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    s2 = 1.0;
                                                }
                                                s1 = s2 * v2 / v1;
                                                lblResult.Text = "Напречно сечение S₁ през т.1 е\n" + s1.ToString("0.0000") + " квадратни метра(m²).";
                                            }; break;
                                        case 2://case 1.3.3
                                            {
                                                try
                                                {
                                                    v1 = Convert.ToDouble(txt1.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    v1 = 1.0;
                                                }
                                                try
                                                {
                                                    s1 = Convert.ToDouble(txt2.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    s1 = 1.0;
                                                }
                                                try
                                                {
                                                    s2 = Convert.ToDouble(txt3.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    s2 = 1.0;
                                                }
                                                v2 = v1 * s1 / s2;
                                                lblResult.Text = "Скорост на флуида v₂ в т.2 е\n" + v2.ToString("0.0000") + " метра в секунда(m/s).";
                                            }; break;
                                        case 3://case 1.3.4
                                            {
                                                try
                                                {
                                                    v1 = Convert.ToDouble(txt1.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    v1 = 1.0;
                                                }
                                                try
                                                {
                                                    s1 = Convert.ToDouble(txt2.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    s1 = 1.0;
                                                }
                                                try
                                                {
                                                    v2 = Convert.ToDouble(txt3.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    v2 = 1.0;
                                                }
                                                s2 = v1 * s1 / v2;
                                                lblResult.Text = "Напречно сечение S₂ през т.2 е\n" + s2.ToString("0.0000") + " квадратни метра(m²).";
                                            }; break;
                                    }; break;//end of case 1.3
                                }
                        }
                    }; break;//end of case 1
                case 1://case2
                    {
                        switch (cbxFormula.SelectedIndex)
                        {
                            case 0:
                                {
                                    double p1, v1, p2, v2;
                                    switch (cbxMagnitude.SelectedIndex)
                                    {
                                        case 0:
                                            {
                                                try
                                                {
                                                    v1 = Convert.ToDouble(txt1.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    v1 = 1.0;
                                                }
                                                try
                                                {
                                                    p2 = Convert.ToDouble(txt2.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    p2 = 1.0;
                                                }
                                                try
                                                {
                                                    v2 = Convert.ToDouble(txt3.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    v2 = 1.0;
                                                }
                                                p1 = p2 * v2 / v1;
                                                lblResult.Text = "Налягането p₁ в състояние 1 е\n" + p1.ToString("0.0000") + " паскала(Pa).";
                                            }; break;
                                        case 1:
                                            {
                                                try
                                                {
                                                    p1 = Convert.ToDouble(txt1.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    p1 = 1.0;
                                                }
                                                try
                                                {
                                                    p2 = Convert.ToDouble(txt2.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    p2 = 1.0;
                                                }
                                                try
                                                {
                                                    v2 = Convert.ToDouble(txt3.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    v2 = 1.0;
                                                }
                                                v1 = p2 * v2 / p1;
                                                lblResult.Text = "Обемът V₁ в състояние 1 е\n" + v1.ToString("0.0000") + " кубични метра(m³).";
                                            }; break;
                                        case 2:
                                            {
                                                try
                                                {
                                                    p1 = Convert.ToDouble(txt1.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    p1 = 1.0;
                                                }
                                                try
                                                {
                                                    v1 = Convert.ToDouble(txt2.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    v1 = 1.0;
                                                }
                                                try
                                                {
                                                    v2 = Convert.ToDouble(txt3.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    v2 = 1.0;
                                                }
                                                p2 = p1 * v1 / v2;
                                                lblResult.Text = "Налягането p₂ в състояние 2 е\n" + p2.ToString("0.0000") + " паскала(Pa).";
                                            }; break;
                                        case 3:
                                            {
                                                try
                                                {
                                                    p1 = Convert.ToDouble(txt1.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    p1 = 1.0;
                                                }
                                                try
                                                {
                                                    v1 = Convert.ToDouble(txt2.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    v1 = 1.0;
                                                }
                                                try
                                                {
                                                    p2 = Convert.ToDouble(txt3.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    p2 = 1.0;
                                                }
                                                v2 = p1 * v1 / p2;
                                                lblResult.Text = "Обемът V₂ в състояние 1 е\n" + v2.ToString("0.0000") + " кубични метра(m³).";
                                            }; break;
                                    }
                                }; break;
                            case 1:
                                {
                                    double p, v, n, r, t;
                                    r = 8.3144598;
                                    switch (cbxMagnitude.SelectedIndex)
                                    {
                                        case 0:
                                            {
                                                try
                                                {
                                                    v = Convert.ToDouble(txt1.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    v = 1.0;
                                                }
                                                try
                                                {
                                                    n = Convert.ToDouble(txt2.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    n = 1.0;
                                                }
                                                try
                                                {
                                                    t = Convert.ToDouble(txt3.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    t = 1.0;
                                                }
                                                p = n * t * r / v;
                                                lblResult.Text = "Налягането p₂ в състояние 2 е\n" + p.ToString("0.0000") + " паскала(Pa).";
                                            }; break;
                                        case 1:
                                            {
                                                try
                                                {
                                                    p = Convert.ToDouble(txt1.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    p = 1.0;
                                                }
                                                try
                                                {
                                                    n = Convert.ToDouble(txt2.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    n = 1.0;
                                                }
                                                try
                                                {
                                                    t = Convert.ToDouble(txt3.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    t = 1.0;
                                                }
                                                v = n * r * t / p;
                                                lblResult.Text = "Обемът V е\n" + v.ToString("0.0000") + " кубични метра(m³).";
                                            }; break;
                                        case 2:
                                            {
                                                try
                                                {
                                                    p = Convert.ToDouble(txt1.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    p = 1.0;
                                                }
                                                try
                                                {
                                                    v = Convert.ToDouble(txt2.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    v = 1.0;
                                                }
                                                try
                                                {
                                                    t = Convert.ToDouble(txt3.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    t = 1.0;
                                                }
                                                n = p * v / (r * t);
                                                lblResult.Text = "Количеството вещество е\n" + n.ToString("0.####") + " мола(mol).";
                                            }; break;
                                        case 3:
                                            {
                                                try
                                                {
                                                    p = Convert.ToDouble(txt1.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    p = 1.0;
                                                }
                                                try
                                                {
                                                    v = Convert.ToDouble(txt2.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    v = 1.0;
                                                }
                                                try
                                                {
                                                    n = Convert.ToDouble(txt3.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    n = 1.0;
                                                }
                                                t = p * v / (n * r);
                                                lblResult.Text = "Температурата T е\n" + t.ToString("0.0000") + " келвина(K).";
                                            }; break;
                                    }
                                }; break;//end of case 2.2
                            case 2://case2.3
                                {
                                    double p1, v1, p2, v2, gamma;
                                    gamma = 6.674e-11;
                                    switch (cbxMagnitude.SelectedIndex)
                                    {
                                        case 0:
                                            {
                                                try
                                                {
                                                    v1 = Convert.ToDouble(txt1.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    v1 = 1.0;
                                                }
                                                try
                                                {
                                                    p2 = Convert.ToDouble(txt2.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    p2 = 1.0;
                                                }
                                                try
                                                {
                                                    v2 = Convert.ToDouble(txt3.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    v2 = 1.0;
                                                }
                                                p1 = p2 * Math.Pow(v2 / v1, gamma);
                                                lblResult.Text = "Налягането p₁ в състояние 1 е\n" + p1.ToString("0.0000") + " паскала(Pa).";
                                            }; break;
                                        case 1:
                                            {
                                                try
                                                {
                                                    p1 = Convert.ToDouble(txt1.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    p1 = 1.0;
                                                }
                                                try
                                                {
                                                    p2 = Convert.ToDouble(txt2.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    p2 = 1.0;
                                                }
                                                try
                                                {
                                                    v2 = Convert.ToDouble(txt3.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    v2 = 1.0;
                                                }
                                                v1 = v2 * Math.Pow(p2 / p1, 1 / gamma);
                                                lblResult.Text = "Обемът V₁ в състояние 1 е\n" + v1.ToString("0.0000") + " кубични метра(m³).";
                                            }; break;
                                        case 2:
                                            {
                                                try
                                                {
                                                    p1 = Convert.ToDouble(txt1.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    p1 = 1.0;
                                                }
                                                try
                                                {
                                                    v1 = Convert.ToDouble(txt2.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    v1 = 1.0;
                                                }
                                                try
                                                {
                                                    v2 = Convert.ToDouble(txt3.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    v2 = 1.0;
                                                }
                                                p2 = p1 * Math.Pow(v1 / v2, gamma);
                                                lblResult.Text = "Налягането p₂ в състояние 2 е\n" + p2.ToString("0.0000") + " паскала(Pa).";
                                            }; break;
                                        case 3:
                                            {
                                                try
                                                {
                                                    p1 = Convert.ToDouble(txt1.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    p1 = 1.0;
                                                }
                                                try
                                                {
                                                    v1 = Convert.ToDouble(txt2.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    v1 = 1.0;
                                                }
                                                try
                                                {
                                                    p2 = Convert.ToDouble(txt3.Text);
                                                }
                                                catch (Exception)
                                                {
                                                    p2 = 1.0;
                                                }
                                                v2 = v1 * Math.Pow(p1/p2,1/gamma);
                                                lblResult.Text = "Обемът V₂ в състояние 1 е\n" + v2.ToString("0.0000") + " кубични метра(m³).";
                                            }; break;
                                    }; break;//end of case2.3
                                }
                        }; break;//end of case 2
                    }
            }
        }

        private void cbxFormula_ValueMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxFormula_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl1.Text = "";
            txt1.Visible = false;
            lbl2.Text = "";
            txt2.Visible = false;
            lbl3.Text = "";
            txt3.Visible = false;
            lbl4.Text = "";
            txt4.Visible = false;
            lblResult.Text = "";
            btnCalculate.Visible = false;
            btnClear.Visible = false;
            switch (cbxField.SelectedIndex)
            {
                case 0:
                    {
                        switch (cbxFormula.SelectedIndex)
                        {
                            case 0:
                                {
                                    picFormula.Image = Resource.formula1_1;
                                }; break;
                            case 1:
                                {
                                    picFormula.Image = Resource.formula1_2;
                                }; break;
                            case 2:
                                {
                                    picFormula.Image = Resource.formula1_3;
                                }; break;
                        }
                    }; break;
                   case 1:
                    {
                        switch (cbxFormula.SelectedIndex)
                        {
                            case 0:
                                {
                                    picFormula.Image = Resource.formula2_1;
                                };break;
                            case 1:
                                {
                                    picFormula.Image = Resource.formula2_2;
                                };break;
                            case 2:
                                {
                                    picFormula.Image = Resource.formula2_3;
                                }; break;
                        };
                    };break;
                   case 2:
                       {
                           switch (cbxFormula.SelectedIndex)
                           {
                               case 0:
                                   {
                                       picFormula.Image = Resource.formula3_1;
                                   }; break;
                               case 1:
                                   {
                                       picFormula.Image = Resource.formula3_2;
                                   }; break;
                               case 2:
                                   {
                                       picFormula.Image = Resource.formula3_3;
                                   }; break;
                           };
                       }; break;
                   case 3:
                       {
                           switch (cbxFormula.SelectedIndex)
                           {
                               case 0:
                                   {
                                       picFormula.Image = Resource.formula4_1;
                                   }; break;
                               case 1:
                                   {
                                       picFormula.Image = Resource.formula4_2;
                                   }; break;
                               case 2:
                                   {
                                       picFormula.Image = Resource.formula4_3;
                                   }; break;
                           };
                       }; break;

            }
            picFormula.Visible = true;
            string[, ,] arrayMagnitudes;
            arrayMagnitudes = new string[,,]
            {
                {
                    {"Сила на привличане F","Маса на първото тяло m₁","Маса на второто тяло m₂","Разстояние между телата R",""},
                    {"Архимедова сила F","Плътност ρ","Обем на потопената част V","",""},
                    {"Скорост на флуида v₁ в т.1","Напречно сечение S₁ през т.1","Скорост на флуида v₂ в т.2","Напречно сечение S₂ през т.2",""}
                },
                {
                    {"Налягането p₁ в състояние 1","Обема V₁ в състояние 1","Налягането p₂ в състояние 2","Обема V₂ в състояние",""},
                    {"Налягонето p","Обема V","Количеството вещество n","Температурата T",""},
                    {"Налягането p₁ в състояние 1","Обема V₁ в състояние 1","Налягането p₂ в състояние 2","Обема V₂ в състояние",""}
                },
                {
                    {"Силата на привличане F","Големината на първия заряд q₁","Големината на втория заряд q₂","Диелектричната проницаемост на средата ε","Разстояниетао между зарядите R"},
                    {"Магнитна сила F","Заряд q на частицата","Скорост v на частицата","Магнитна индукция B","Ъгъл θ между скоростта и индукцията"},
                    {"Съпротивление на проводника R","Специфично съпротивление на материала ρ","Дължина на проводника L","Напречно сечение на проводника s",""}
                },
                {
                    {"Ъгъл на падане α","Показател на пречупване n₁ на първата среда","Ъгъл на пречупване β","Показател на пречупване n₂ на втората среда",""},
                    {"Дължина в покой L₀","Дължина в движение L","Скорост v","",""},
                    {"Честота на светлинната вълната ν","Отделителна работа на материала A","Кинетична енергия E на най-бързите електрони","",""}
                }
            };
            lblMagnitude.Visible = true;
            cbxMagnitude.Visible = true;

            List<string> listMagnitude;
            listMagnitude = new List<string> {};
            for (int i = 0; i < 5; i++)
            {
                if (arrayMagnitudes[cbxField.SelectedIndex, cbxFormula.SelectedIndex, i] != "")
                {
                    listMagnitude.Add(arrayMagnitudes[cbxField.SelectedIndex, cbxFormula.SelectedIndex, i]);
                }
            }
            string[] arrayMagnitude;
            arrayMagnitude = listMagnitude.ToArray();
            changeMagnitude(arrayMagnitude);
        }

        private void cbxField_SelectedIndexChanged(object sender, EventArgs e)
        {
            picHome.Visible = false;
            lblHallo.Visible = false;
            lblMagnitude.Visible = false;
            cbxMagnitude.Visible = false;
            picField.Visible = true;
            picFormula.Visible = false;
            switch (cbxField.SelectedIndex)
            {
                case 0:
                    {
                        picField.Image = Resource.mechanics;
                    }; break;
                case 1:
                    {
                        picField.Image = Resource.thermodynamics;
                    }; break;
                case 2:
                    {
                        picField.Image = Resource.electricity;
                    }; break;
                case 3:
                    {
                        picField.Image = Resource.waves;
                    }; break;
            }
            lbl1.Text = "";
            txt1.Visible = false;
            lbl2.Text = "";
            txt2.Visible = false;
            lbl3.Text = "";
            txt3.Visible = false;
            lbl4.Text = "";
            txt4.Visible = false;
            lblResult.Text = "";
            btnCalculate.Visible = false;
            btnClear.Visible = false;
            int index = cbxField.SelectedIndex;
            lblFormula.Visible = true;
            cbxFormula.Visible = true;
            string[,] arrayFormulas;
            arrayFormulas = new string[,]
            {
                {"Закон на Нютон","Закон на Архимед","Уравнение за непрекъснатост"},
                {"Закон на Бойл-Мариот","Уравнение на Клапейрон-Менделеев","Уравнение на Поасон"},
                {"Закон на Кулон","Магнитна сила върху заредена частица","Съпротивление на проводник"},
                {"Закон на Снелиус","Лоренцово скъсяване","Уравнение на Айнщайн"}
            };
            string[] arrayFormula;
            arrayFormula = new string[3];
            for (int i = 0; i < 3; i++)
			{
			    arrayFormula[i] = arrayFormulas[index,i];
			}
            changeFormula(arrayFormula);
        }

        private void cbxMagnitude_SelectedIndexChanged(object sender, EventArgs e)
        {
            picField.Visible = false;
            
            Clear();
            int[,] numbers;
            numbers = new int[,] {{4,3,4},{4,4,4},{5,5,4},{4,4,3}};
            string[, ,] arrayMagnitudes;
            arrayMagnitudes = new string[,,]
            {
                {
                    {"Сила на привличане F в нютони(N)","Маса на първото тяло m₁ в килограми(kg)","Маса на второто тяло m₂ в килограми(kg)","Разстояние между телата R в метри(m)",""},
                    {"Архимедова сила F в нютони(N)","Плътност ρ в килограм на кубичен метър(kg/m³)","Обем на потопената част V в кубични метри(m³)","",""},
                    {"Скорост на флуида v₁ в т.1 в метри в секунда(m/s)","Напречно сечение S₁ през т.1 в квадратни метри(m²)","Скорост на флуида v₂ в т.2 в метри в секунда(m/s)","Напречно сечение S₂ през т.2 в квадратни метри(m²)",""}
                },
                {
                    {"Налягането p₁ в състояние 1 в паскали(Pa)","Обема V₁ в състояние 1 в кубични метри(m³)","Налягането p₂ в състояние 2 в паскали(Pa)","Обема V₂ в състояние 2 в кубични метри(m³)",""},
                    {"Налягонето p в паскали(Pa)","Обема V в кубични метри(m³)","Количеството вещество n в молове(mol)","Температурата T в келвини(K)",""},
                    {"Налягането p₁ в състояние 1 в паскали(Pa)","Обема V₁ в състояние 1 в кубични метри(m³)","Налягането p₂ в състояние 2 в паскали(Pa)","Обема V₂ в състояние 2 в кубични метри(m³)",""}
                },
                {
                    {"Силата на привличане F в нютони(N)","Големината на първия заряд q₁ в кулони(C)","Големината на втория заряд q₂ в кулони(C)","Диелектричната проницаемост на средата ε","Разстояниетао между зарядите R в метри(m)"},
                    {"Магнитна сила F в нютони(N)","Заряд q на частицата в кулони(C)","Скорост v на частицата в метри в секунда(m/s)","Магнитна индукция B в нютон на метър по ампер (N/(m·A))","Ъгъл θ между скоростта и индукцията в радиани(rad)"},
                    {"Съпротивление на проводника R в омове(Ω)","Специфично съпротивление на материала ρ в ом по метър(Ωm)","Дължина на проводника L в метри(m)","Напречно сечение на проводника s в метри в секунда(m/s)",""}
                },
                {
                    {"Ъгъл на падане α в радиани(rad)","Показател на пречупване n₁ на първата среда","Ъгъл на пречупване β в радиани(rad)","Показател на пречупване n₂ на втората среда",""},
                    {"Дължина в покой L₀ в метри(m)","Дължина в движение L в метри(m)","Скорост v в метри в секунда(m/s)","",""},
                    {"Честота на светлинната вълната ν в херци(Hz)","Отделителна работа на материала A в джаули(J)","Кинетична енергия E на най-бързите електрони в джаули(J)","",""}
                }
            };
            List<string> listMagnitudes;
            listMagnitudes = new List<string> { };
            for (int i = 0; i < 5; i++)
            {
                if (i!=cbxMagnitude.SelectedIndex)
                {
                    listMagnitudes.Add(arrayMagnitudes[cbxField.SelectedIndex, cbxFormula.SelectedIndex, i]);
                }
            }
            lbl1.Visible = true;
            lbl1.Text = listMagnitudes[0];
            txt1.Visible = true;
            lbl2.Visible = true;
            lbl2.Text = listMagnitudes[1];
            txt2.Visible = true;
            if (numbers[cbxField.SelectedIndex, cbxFormula.SelectedIndex] > 3)
            {
                lbl3.Visible = true;
                lbl3.Text = listMagnitudes[2];
                txt3.Visible = true;
            }
            if (numbers[cbxField.SelectedIndex, cbxFormula.SelectedIndex] > 4)
            {
                lbl4.Visible = true;
                lbl4.Text = listMagnitudes[3];
                txt4.Visible = true;
            }
            btnCalculate.Visible = true;
            btnClear.Visible = true;
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void formPC_Load(object sender, EventArgs e)
        {

        }
        

    }
}
