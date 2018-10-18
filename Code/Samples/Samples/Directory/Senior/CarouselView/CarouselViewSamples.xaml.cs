
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Samples.Directory.Senior.CarouselView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CarouselViewSamples : ContentPage
	{
		public CarouselViewSamples ()
		{
			InitializeComponent ();

            BindingContext = new MainViewModel();
        }
	}


    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Modelo> Modelos { get; private set; } = new ObservableCollection<Modelo>();

        public MainViewModel()
        {
            Inicializar();
        }

        private void Inicializar()
        {
            Modelos.Add(new Modelo { Texto = "Texto Um", CorDeFundo = Color.Black, TemBotao = false });
            Modelos.Add(new Modelo { Texto = "Texto Dois", CorDeFundo = Color.Red, TemBotao = false });
            Modelos.Add(new Modelo { Texto = "Texto Tres", CorDeFundo = Color.Green, TemBotao = true });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Seta um novo valor a propriedade do objeto
        /// Verifica se os valores são iguais,se forem retorna
        /// se Nao  chama o evento OnPropertyChanged
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="backingField"></param>
        /// <param name="value"></param>
        /// <param name="propertyName"></param>
        protected void SetValue<T>(ref T backingField, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingField, value))
                return;

            backingField = value;

            OnPropertyChanged(propertyName);
        }
    }

    public class Modelo
    {
        public string Texto { get; set; }
        public Color CorDeFundo { get; set; }
        public bool TemBotao { get; set; }

        public Modelo()
        {

        }
    }
}