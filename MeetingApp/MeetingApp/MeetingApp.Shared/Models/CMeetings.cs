using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.Services.Maps;
using Windows.Storage.Streams;
using System.Diagnostics;

namespace MeetingApp.Models
{
    class CMeetings : INotifyPropertyChanged
    {
        // trzeba dodac numery do osób
        // trzeba dodać możliwyBudżet imprezy
        // 
        
        private CPerson mInviter;
        private string mName { get; set; }
        private List<CPerson> mListOfPersonToInvite { get; set; }
        private MapAddress mLocation { get; set; }
        private DateTime mDateOfMeetings { get; set; }


        public void setInviter(CPerson aInviterPerson)
        {
            if (mInviter != aInviterPerson)
            {
                mInviter = aInviterPerson;
                OnPropertyChanged("SetInviter");

            }
        }

        public void getInviter()
        {
          
        }

        public void Invite(CPerson aPersonToAdd)
        {
            mListOfPersonToInvite.Add(aPersonToAdd);
            OnPropertyChanged();
            Debug.WriteLine("Zaprosiłem ");
                                                                    //      Debug.WriteLine("Dodałem osobe");
        }


        // GETTERY
        public List<CPerson> getListOfPerson()
        {
            return mListOfPersonToInvite;
        }
        public MapAddress getLocation()
        {
            return mLocation;
        }
        public DateTime getDateOfMeetings()
        {
            return mDateOfMeetings;
        }
        public string getName()
        {
            return mName;
        }

        // SETTERY
        public void SetName(string aNameToAdd)
        {
            mName = aNameToAdd;
            OnPropertyChanged();
            //   mName != NULL ? Debug.WriteLine("Dodałem date") : Debug.WriteLine("Nie dodałem osobe"); ;
            // return mValueToReturn;
        }
        public void SetDate(DateTime aDateOfMeetings)
        {
          //  DateTime tempDate = new DateTime();
            DateTime tempDate;
            tempDate = aDateOfMeetings;
            //    bool mValueToReturn = false;                                                        //                                 tempDate != NULL ? mValueToReturn = true : mValueToReturn = false;

            if (tempDate != null)
            {
               OnPropertyChanged();

                mDateOfMeetings = tempDate;
              // mListOfPersonToInvite<CPerson>.Add(tempDate);
               Debug.WriteLine("Dodałem Date");
            }
            //      return mValueToReturn;
        }
        public void SetPersons(List<CPerson> aListOfPerson)
        {
            mListOfPersonToInvite = aListOfPerson;
        }
        public void SetLocation(MapAddress aLocation)
        {
            mLocation = aLocation;

        }

        // 
             
        public event PropertyChangedEventHandler PropertyChanged;

    

        public CMeetings(CPerson aInviter, string aName, MapAddress aMapAddress, DateTime aDateTime, List<CPerson> aListOfPersonToInvite)
        {
          //  SetOrganizator(aInviter);
            SetName(aName);
            SetLocation(aMapAddress);
            SetDate(aDateTime);
            SetPersons(aListOfPersonToInvite);
        }

        public CMeetings()
        {
          //  SetOrganizator(null);
            SetName("");
            SetLocation(null);
            SetDate(DateTime.MinValue);
            SetPersons(null);
            setInviter(null);
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            //System.Diagnostics.Debug("Zmienilem Pole w Meetings");
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
