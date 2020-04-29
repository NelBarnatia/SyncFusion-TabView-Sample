using Syncfusion.XForms.TabView;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Test
{
    public class ContactInfo
    {
        public string Name { get; set; }
        public long Number { get; set; }
    }

    public class ContactsViewModel : INotifyPropertyChanged
    {
        public ICommand OutputAgeCommand { get; private set; }

        public string SelectedItemText { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<ContactInfo> contactList;
        public ObservableCollection<ContactInfo> ContactList
        {
            get { return contactList; }
            set { contactList = value; OnPropertyChanged(nameof(ContactList)); }
        }

        private ObservableCollection<string> listaTabItem;
        public ObservableCollection<string> ListaTabItem
        {
            get { return listaTabItem; }
            set { listaTabItem = value; OnPropertyChanged(nameof(ListaTabItem)); }
        }
        public static string GenerateName(int len)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;


        }

        public ContactsViewModel()
        {
            ListaTabItem = new ObservableCollection<string>
            {
                "TITLE 1",
                "TITLE 2",
                "TITLE 3",
                "TITLE 4",
                "TITLE 4",
                "TITLE 4",
                "TITLE 4",
                "TITLE 4",
                "TITLE 4",
                "TITLE 4",
                "TITLE 4",
            };

            var randomName = GenerateName(6);

            ContactList = new ObservableCollection<ContactInfo>
            {
                new ContactInfo { Name = randomName, Number = 7363750 },
                new ContactInfo { Name = randomName, Number = 7323250 },
                new ContactInfo { Name = randomName, Number = 7239121 },
                new ContactInfo { Name = randomName, Number = 2329823 },
                new ContactInfo { Name = randomName, Number = 8013481 },
                new ContactInfo { Name = randomName, Number = 7872329 },
                new ContactInfo { Name = randomName, Number = 7317750 },
                new ContactInfo { Name = randomName, Number = 7363750 },
                new ContactInfo { Name = randomName, Number = 7323250 },
                new ContactInfo { Name = randomName, Number = 7239121 },
                new ContactInfo { Name = randomName, Number = 2329823 },
            };

            OutputAgeCommand = new Command<ContactInfo>(OutputAge);
        }

        void OutputAge(ContactInfo person)
        {
            SelectedItemText = string.Format("{0} is {1} years old.", person.Name, person.Number);
            OnPropertyChanged("SelectedItemText");
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
