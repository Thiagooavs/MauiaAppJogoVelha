namespace MauiaAppJogoVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "O";
        int cont = 0;
        int cc;

        public MainPage()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button disparador = (Button)sender;//Fala que o sender é um botão
            cc = cont;
            cont = cc + 1;
            disparador.IsEnabled = false;



            if (vez == "O")
            {
                disparador.Text = "O";
                vez = "X";

            }
            else
            {
                disparador.Text = "X";
                vez = "O";
            }//fecha if, que controla a vez do jogador

            //X ganhou 
            if (btn10.Text == "X" &&
               btn11.Text == "X" &&
               btn12.Text == "X")
            {
                DisplayAlert("Parabens!!", "O X ganhou", "Fechar");
                btn10.BackgroundColor = Colors.Green;
                btn11.BackgroundColor = Colors.Green;
                btn12.BackgroundColor = Colors.Green;
                limpar();
            }
            else if (btn20.Text == "X" &&
                    btn21.Text == "X" &&
                    btn22.Text == "X")
            {
                DisplayAlert("Parabens!!", "O X ganhou", "Fechar");
                btn20.BackgroundColor = Colors.Green;
                btn21.BackgroundColor = Colors.Green;
                btn22.BackgroundColor = Colors.Green;
                limpar();
            }
            else if (btn30.Text == "X" &&
                    btn31.Text == "X" &&
                    btn32.Text == "X")
            {
                DisplayAlert("Parabens!!", "O X ganhou", "Fechar");
                btn30.BackgroundColor = Colors.Green;
                btn32.BackgroundColor = Colors.Green;
                btn31.BackgroundColor = Colors.Green;
                limpar();
            }
            else if (btn10.Text == "X" &&
                   btn20.Text == "X" &&
                   btn30.Text == "X")
            {
                DisplayAlert("Parabens!!", "O X ganhou", "Fechar");
                btn10.BackgroundColor = Colors.Green;
                btn20.BackgroundColor = Colors.Green;
                btn30.BackgroundColor = Colors.Green;
                limpar();
            }
            else if (btn11.Text == "X" &&
                   btn21.Text == "X" &&
                   btn31.Text == "X")
            {
                DisplayAlert("Parabens!!", "O X ganhou", "Fechar");
                btn11.BackgroundColor = Colors.Green;
                btn21.BackgroundColor = Colors.Green;
                btn31.BackgroundColor = Colors.Green;
                limpar();

            }
            else if (btn12.Text == "X" &&
                   btn22.Text == "X" &&
                   btn32.Text == "X")
            {
                DisplayAlert("Parabens!!", "O X ganhou", "Fechar");
                btn12.BackgroundColor = Colors.Green;
                btn32.BackgroundColor = Colors.Green;
                btn22.BackgroundColor = Colors.Green;
                limpar();
            }
            else if (btn10.Text == "X" &&
                   btn21.Text == "X" &&
                   btn32.Text == "X")
            {
                DisplayAlert("Parabens!!", "O X ganhou", "Fechar");
                btn10.BackgroundColor = Colors.Green;
                btn32.BackgroundColor = Colors.Green;
                btn21.BackgroundColor = Colors.Green;
                limpar();
            }
            else if (btn12.Text == "X" &&
                   btn21.Text == "X" &&
                   btn30.Text == "X")
            {
                DisplayAlert("Parabens!!", "O X ganhou", "Fechar");
                btn12.BackgroundColor = Colors.Green;
                btn21.BackgroundColor = Colors.Green;
                btn30.BackgroundColor = Colors.Green;
                limpar();
            }         
            else if (btn10.Text == "O" &&//O ganhou
               btn11.Text == "O" &&
               btn12.Text == "O")
            {
                DisplayAlert("Parabens!!", "O O ganhou", "Fechar");
                btn10.BackgroundColor = Colors.Green;
                btn11.BackgroundColor = Colors.Green;
                btn12.BackgroundColor = Colors.Green;
                limpar();
            }
            else if (btn20.Text == "O" &&
                    btn21.Text == "O" &&
                    btn22.Text == "O")
            {
                DisplayAlert("Parabens!!", "O O ganhou", "Fechar");
                btn20.BackgroundColor = Colors.Green;
                btn21.BackgroundColor = Colors.Green;
                btn22.BackgroundColor = Colors.Green;
                limpar();
            }
            else if (btn30.Text == "O" &&
                    btn31.Text == "O" &&
                    btn32.Text == "O")
            {
                DisplayAlert("Parabens!!", "O O ganhou", "Fechar");
                btn30.BackgroundColor = Colors.Green;
                btn32.BackgroundColor = Colors.Green;
                btn31.BackgroundColor = Colors.Green;
                limpar();
            }
            else if (btn10.Text == "O" &&
                   btn20.Text == "O" &&
                   btn30.Text == "O")
            {
                DisplayAlert("Parabens!!", "O O ganhou", "Fechar");
                btn10.BackgroundColor = Colors.Green;
                btn30.BackgroundColor = Colors.Green;
                btn20.BackgroundColor = Colors.Green;
                limpar();
            }
            else if (btn11.Text == "O" &&
                   btn21.Text == "O" &&
                   btn31.Text == "O")
            {
                DisplayAlert("Parabens!!", "O O ganhou", "Fechar");
                btn11.BackgroundColor = Colors.Green;
                btn21.BackgroundColor = Colors.Green;
                btn31.BackgroundColor = Colors.Green;
                limpar();
            }
            else if (btn12.Text == "O" &&
                   btn22.Text == "O" &&
                   btn32.Text == "O")
            {
                DisplayAlert("Parabens!!", "O O ganhou", "Fechar");
                btn12.BackgroundColor = Colors.Green;
                btn32.BackgroundColor = Colors.Green;
                btn32.BackgroundColor = Colors.Green;
                limpar();
            }
            else if (btn10.Text == "O" &&
                   btn21.Text == "O" &&
                   btn32.Text == "O")
            {
                DisplayAlert("Parabens!!", "O O ganhou", "Fechar");
                btn10.BackgroundColor = Colors.Green;
                btn32.BackgroundColor = Colors.Green;
                btn21.BackgroundColor = Colors.Green;
                limpar();
            }
            else if (btn12.Text == "O" &&
                   btn21.Text == "O" &&
                   btn30.Text == "O")
            {
                DisplayAlert("Parabens!!", "O O ganhou", "Fechar");
                btn12.BackgroundColor = Colors.Green;
                btn21.BackgroundColor = Colors.Green;
                btn30.BackgroundColor = Colors.Green;
                limpar();
            }         
            else if (cont == 9)//Empate
            {
                DisplayAlert("Empate!!", "Ambos são péssimos", "Fechar");
                limpar();
                btn10.BackgroundColor = Colors.Red;
                btn11.BackgroundColor = Colors.Red;
                btn12.BackgroundColor = Colors.Red;
                btn20.BackgroundColor = Colors.Red;
                btn21.BackgroundColor = Colors.Red;
                btn22.BackgroundColor = Colors.Red;
                btn30.BackgroundColor = Colors.Red;
                btn31.BackgroundColor = Colors.Red;
                btn32.BackgroundColor = Colors.Red;
                

            }

        }//Fecha Button_Clicked

        private void limpar()
        {
            cont = 0;   
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";

            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;
            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;


            btn10.BackgroundColor = Colors.Transparent;
            btn11.BackgroundColor = Colors.Transparent;
            btn12.BackgroundColor = Colors.Transparent;
            btn20.BackgroundColor = Colors.Transparent;
            btn21.BackgroundColor = Colors.Transparent;
            btn22.BackgroundColor = Colors.Transparent;
            btn30.BackgroundColor = Colors.Transparent;
            btn31.BackgroundColor = Colors.Transparent;
            btn32.BackgroundColor = Colors.Transparent;



        }

    }

}
