using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CandidatoAPP.ViewModel
{
    public class CandidatoViewModel : INotifyPropertyChanged
     {
            public event PropertyChangedEventHandler PropertyChanged;
            protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }


            public CandidatoViewModel()
            {
                PretensaoSalarial = 0;


                GravarCommand = new Command(() => {
                    var msg = Nome + " " + Sobrenome + 
                    "\n E-mail: "  + Email + "\n  " + 
                    "Pretensão: " + PretensaoSalarial + " mil reais\n " +
                    ResumoProfissional;
                    App.Current.MainPage.DisplayAlert("Candidato:", msg, "Ok");
                });

                LimparCommand = new Command(() => {
                    this.Nome = "";
                    this.Sobrenome = "";
                    this.Email = "";
                    this.PretensaoSalarial = 0;
                    this.ResumoProfissional = "";
                });

            }


            private String nome;
            public String Nome
            {
                get { return nome; }
                set
                {
                    nome = value;
                    NotifyPropertyChanged();
                }
            }

            private String sobrenome;
            public String Sobrenome
            {
                get { return sobrenome; }
                set
                {
                    sobrenome = value;
                    NotifyPropertyChanged();
                }
            }

        private String email;
            public String Email
            {
                get { return email; }
                set
                {
                    email = value;
                    NotifyPropertyChanged();
                }
            }


            private int pretensaoSalarial;
            public int PretensaoSalarial
            {
                get { return pretensaoSalarial; }
                set
                {
                    pretensaoSalarial = value;
                    NotifyPropertyChanged();
                }
            }

            private String resumoProfissional;
            public String ResumoProfissional
            {
                get { return resumoProfissional; }
                set
                {
                    resumoProfissional = value;
                    NotifyPropertyChanged();
                }
            }


            public ICommand GravarCommand { get; set; }

            public ICommand LimparCommand { get; set; }

        }
    }
