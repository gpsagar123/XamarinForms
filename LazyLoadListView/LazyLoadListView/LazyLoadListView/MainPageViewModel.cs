using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace LazyLoadListView
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<MyData> _listData;

        public ObservableCollection<MyData> ListData
        {
            get { return _listData; }
            set
            {
                _listData = value;
                OnPropertyChanged();
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        SQLiteConnection conn;
        int _offset = 0;

        public MainPageViewModel()
        {

            conn = DependencyService.Get<ISQLite>().GetConnection();
            ListData = new ObservableCollection<MyData>();

            InsertSampleData();
            PopulateListData();
        }

        private void InsertSampleData()
        {
            if(conn != null)
            {
                List<MyData> listItems = new List<MyData>();

                for (int i = 0; i < 200; i++)
                {
                    listItems.Add(new MyData() { Title = $"Title {i}", Description = $"Description {i}" });
                }

                IEnumerable<MyData> data = listItems as IEnumerable<MyData>;
                conn.InsertAll(data);
            }
        }

        private void PopulateListData()
        {
            string sql = $"SELECT * FROM MyData LIMIT 20 OFFSET {_offset}";

            List<MyData> data = conn.Query<MyData>(sql);

            ListData = new ObservableCollection<MyData>(data as List<MyData>);


        }

        internal void LoadMoreItems(MyData currentItem)
        {
            int itemIndex = ListData.IndexOf(currentItem);

            _offset = ListData.Count;

            if(ListData.Count - 3 == itemIndex)
            {
                string sql = $"SELECT * FROM MyData LIMIT 20 OFFSET {_offset}";

                List<MyData> data = conn.Query<MyData>(sql);

                foreach (MyData item in data)
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        ListData.Add(item);
                    }
                    );
                }
            }
        }

        

      


    }
}
