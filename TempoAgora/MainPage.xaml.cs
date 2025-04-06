using TempoAgora.Models;

namespace TempoAgora
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_cidade.Text))
                {
                    Tempo? t = await DataService.GetPrevisao(txt_cidade.Text);

                    if (t != null)
                    {
                        string dados_previsao = $"Latitude: {t.lat}\n" +
                                                $"Longitude: {t.lon}\n" +
                                                $"Nascer do sol: {t.sunrise}\n" +
                                                $"Por do sol: {t.sunset}\n" +
                                                $"Temp máx: {t.temp_max}\n" +
                                                $"Temp min: {t.temp_min}\n" +
                                                $"Descrição: {t.description}\n" +
                                                $"Velocidade do vento: {t.speed}\n" +
                                                $"Visibilidade: {t.visibility}";

                        lbl_res.Text = dados_previsao;
                    }
                    else
                    {
                        lbl_res.Text = "Cidade Não Localizada.";
                    }
                }
                else
                {
                    lbl_res.Text = "Preencha a cidade.";
                }
            }
            catch (HttpRequestException httpEx)
            {
                await DisplayAlert("Erro de Conexão", "Verifique sua conexão com a internet.", "OK");
            }


            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
    }

