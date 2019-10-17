using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cha10_01
{
    public class AddViewModel : ViewModelBase
    {
        // 인터페이스 커맨드 객체 생성
        public ICommand ClearCommand { private set; get; }
        public ICommand ClearEnterCommand { private set; get; }
        public ICommand BackspaceCommand { private set; get; }


        public ICommand NumberCommand { private set; get; }
        public ICommand DecimalPointCommand { private set; get; }

        public ICommand AddCommand { private set; get; }


        double result = 0;

        // 23 + 45 + => HistoryString
        // 67 => CurrentEntry

        string historyString;
        public string HistoryString
        {
            get
            {
                return this.historyString;
            }
            private set
            {
                Setproperty(ref this.historyString, value);
                RefreshCanExecute();
            }
        }
        private string currentEntry;
        public string CurrentEntry
        {
            get
            {
                return this.currentEntry;
            }
            set
            {
                Setproperty(ref this.currentEntry, value);
                RefreshCanExecute();
            }
        }

        bool isSumDisplayed = false;

        //생성자
        public AddViewModel()
        {
            // 함수 등록, 람다식으로
            ClearCommand = new Command(
                execute: () =>
                {
                    this.result = 0;
                    HistoryString = "";
                    CurrentEntry = "0";
                    isSumDisplayed = false;

                    RefreshCanExecute();
                }
                );

            ClearEnterCommand = new Command(
                execute: () =>
                {
                    CurrentEntry = "0";
                    isSumDisplayed = false;
                }
                );

            BackspaceCommand = new Command(

                execute:() =>
                {
                    CurrentEntry = CurrentEntry.Substring(0, CurrentEntry.Length - 1);
                    if (CurrentEntry.Length == 0)
                    {
                        CurrentEntry = "0";
                    }
                },
                // ture 반환시 enable, false 반환시 disable
                canExecute:() =>
                {
                    return (!isSumDisplayed && (CurrentEntry.Length > 1 || (CurrentEntry.Length > 0 && CurrentEntry[0] != '0')));
                }

                );

            NumberCommand = new Command<string>(
                execute:(string param) =>
                {
                    if(isSumDisplayed || CurrentEntry == "0")
                    {
                        CurrentEntry = param;
                    }else
                    {
                        CurrentEntry += param;
                    }
                    isSumDisplayed = false;
                    RefreshCanExecute();
                },
                canExecute:(string param) =>
                {
                    return isSumDisplayed || CurrentEntry.Length < 16;
                }
                   
                );

            DecimalPointCommand = new Command(

                execute:() =>
                {
                    if (isSumDisplayed)
                    {
                        CurrentEntry = "0.";
                    }
                    else
                    {
                        CurrentEntry += ".";
                    }
                    isSumDisplayed = false;
                    RefreshCanExecute();
                },

                canExecute:() =>
                {
                    return isSumDisplayed || !CurrentEntry.Contains(".");
                }
                );

            AddCommand = new Command(
                execute:() =>
                {
                    double value = Double.Parse(CurrentEntry);
                    HistoryString += value.ToString() + "+";
                    result += value;
                    CurrentEntry = result.ToString();
                    isSumDisplayed = true;
                    RefreshCanExecute();

                },
                canExecute:() =>
                {
                    return !isSumDisplayed;
                }
                
                );

            HistoryString = "";
            CurrentEntry = "0";

        }

        private void RefreshCanExecute()
        {
            // 다시 한번 enable, disable을 갱신
            // 화면단에서 각각의 canexecute 호출
            ((Command)BackspaceCommand).ChangeCanExecute();
            ((Command)NumberCommand).ChangeCanExecute();
            ((Command)DecimalPointCommand).ChangeCanExecute();
            ((Command)AddCommand).ChangeCanExecute();
        }

        // 현재 상태 저장하기, 다시 복원하기 app에서!

        public void SaveData()
        {
            Application.Current.Properties["CurrentEntry"] = this.CurrentEntry;
            Application.Current.Properties["HistoryString"] = this.HistoryString;
            Application.Current.Properties["isSumDispalyed"] = this.isSumDisplayed;
            Application.Current.Properties["Result"] = this.result;

            // 위에 코드만 적으면 os에 따라 될 때도 있고 안 될 때도 있음!
            Application.Current.SavePropertiesAsync();

        }

        public void ResoreData()
        {
            this.CurrentEntry = GetResourceData("CurrentEntry", "0");
            this.HistoryString = GetResourceData("HistoryString", "");
            this.isSumDisplayed = GetResourceData("isSumDisplayed", false);
            this.result = GetResourceData("result", 0.0);

            RefreshCanExecute();
        }

        // 데이터가 존재하지 않을 수 있으므로!
        private T GetResourceData<T>(string key, T defaultData)
        {
            if (Application.Current.Properties.ContainsKey(key))
            {
                return (T)Application.Current.Properties[key];
            }else
            {
                return defaultData;
            }
        }





    }
}
