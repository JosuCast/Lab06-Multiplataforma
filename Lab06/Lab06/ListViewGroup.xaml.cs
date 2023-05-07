using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab06
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {

        public ObservableCollection<GroupedItems> GroupedItems { get; set; }

        public ListViewGroup()
        {
            InitializeComponent();

            var contactos = new List<Contacto>
            {
                new Contacto { Nombre = "Ximena", Apellido = "Avedaño" },
                new Contacto { Nombre = "Josue", Apellido = "Castillo" },
                new Contacto { Nombre = "Pedro", Apellido = "Cervantes" },
                new Contacto { Nombre = "Diego", Apellido = "Flores" },
                new Contacto { Nombre = "Fernanda", Apellido = "Alcazar" }
            };

            var grouped = from item in contactos
                          group item by item.Clave into itemGroup
                          select new GroupedItems(itemGroup.Key, itemGroup);

            GroupedItems = new ObservableCollection<GroupedItems>(grouped);


            BindingContext = this;
        }
             


          
    }
    
}