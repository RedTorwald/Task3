namespace TaskForm3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
        InitializeComponent();
        }   

       public class Vekt
       {
            public double X;
            public double Y;
            public double Z;
                    
            public Vekt(double X, double Y, double Z)       // конструктор
            {
                this.X = X;
                this.Y = Y;
                this.Z = Z;
            }
            public static Vekt operator +(Vekt A, Vekt B)  //переопределение оператора +
            {
                return new Vekt(
                     A.X+B.X,
                     A.Y+B.Y,
                     A.Z+B.Z
                );           
            }
            public static Vekt operator -(Vekt A, Vekt B)  //переопределение оператора -
            {
                return new Vekt(
                     B.X-A.X,
                     B.Y-A.Y,
                     B.Z-A.Z
                );           
            }                
            public double Add(Vekt A)           //скалярное произведение 2 векторов
            {
                double result= this.X*A.X + this.Y*A.Y + this.Z*A.Z ;        
            return result;
            }               
            public double Size                 // поиск размера вектора
            {
                get
                {
                    return Math.Sqrt((Math.Pow(this.X, 2) + Math.Pow(this.Y, 2) + Math.Pow(this.Z, 2)));                                     
                }
            }
            public static Vekt operator *(Vekt A, Vekt B)  //векторное произведение 
            {
                return new Vekt(
                     A.Y*B.Z - A.Z*B.Y,
                     A.Z*B.X - A.X*B.Z,
                     A.X*B.Y - A.Y*B.X
                );  
            }           
        }

        private void Calculate()
        {
            try
            {
                
                double a = Convert.ToDouble(this.textBox1.Text);
                double b = Convert.ToDouble(this.textBox2.Text);
                double c = Convert.ToDouble(this.textBox3.Text);
                Vekt A1= new (a, b, c);
                double d = Convert.ToDouble(this.textBox4.Text);
                double r = Convert.ToDouble(this.textBox5.Text);
                double f = Convert.ToDouble(this.textBox6.Text);
                Vekt A2= new (d, r, f);
                Vekt A3;
                Vekt A4;
                Vekt A5;
                double value;       
                switch(Result.Text)
                {
                    case "A1+A2":                        
                        A3= A1+A2; 
                        textBox7.Text=($"{A3.X} {A3.Y} {A3.Z} - сложение векторов А1 и А2");
                        break;
                    case "A1-A2":                        
                        A4= A2-A1;
                        textBox7.Text=($"{A4.X} {A4.Y} {A4.Z} - вычитание векторов А1 и А2");
                        break;
                    case "A1*A2":                        
                        textBox7.Text=($"{A1.Add(A2)} - скалярное произведение векторов А1 и А2");  
                        break;
                    case "[A1*A2]":                        
                        A5=A1*A2; 
                        textBox7.Text=($"{A5.X} {A5.Y} {A5.Z} - векторное произведение");
                        break; 
                    case "size(A1)": 
                        value=A1.Size; 
                        textBox7.Text=($"{value} - размер вектора А1");
                        break;
                    case "size(A2)": 
                        value=A2.Size; 
                        textBox7.Text=($"{value} - размер вектора А2");
                        break;
                    case "size(A3)":                
                        A3= A1+A2;
                        value=A3.Size; 
                        textBox7.Text=($"{value} - размер вектора А3");
                        break;
                }


            } catch (FormatException) {
                textBox7.Text=($"некорректный ввод");
            }
        }       
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             Calculate();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Result_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {

        }        
        
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox4.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox5.Focus();
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox6.Focus();
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1.Focus();
            }
        }
    }
}