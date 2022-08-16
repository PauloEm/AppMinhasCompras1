using AppMinhasCompras.Model;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMinhasCompras.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NovoProduto : ContentPage
    {
        public NovoProduto()
        {
            InitializeComponent();
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            try
            {

                Produto p = new Produto
                {
                    Nome = txt_nome.Text,
                    Quantidade = Convert.ToDouble(txt_quantidade.Text),
                    Preco = Convert.ToDouble(txt_preco.Text),   
                };


                await App.Database.Insert(p);


                await DisplayAlert("Sucesso!", "Produto Cadastrado", "OK");


 
                await Navigation.PushAsync(new Listagem());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}