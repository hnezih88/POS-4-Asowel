// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace POS.Entities
{

    // OrderDetailsTemp
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class OrderDetailsTemp : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<string> _statusItems = new ObservableCollection<string> { "BreakFast", "Starter", "Main", "Dessert", "Drink" };

        private int _ordertempId;// ordernote_id (Primary key) (length: 10)
        private string _productId; // product_id (Primary key) (length: 10)
        private int _chairId;
        private string _stats;      // SelectedStats
        private string _note;       // note (length: 500)
        private int _quan;          // quan
        private string _oldstat;

        public ObservableCollection<string> StatusItems
        {
            get { return _statusItems; }
            set
            {
                _statusItems = value;
                OnPropertyChanged("StatusItems");
            }
        }


        public int OrdertempId
        {
            get { return _ordertempId; }
            set
            {
                _ordertempId = value;
                OnPropertyChanged("OrdertempId");
            }
        } // ordertemp_id (Primary key) (length: 10)
        public string ProductId
        {
            get { return _productId; }
            set
            {
                _productId = value;
                OnPropertyChanged("ProductId");
            }
        } // product_id (Primary key) (length: 10)
        public int ChairId
        {
            get { return _chairId; }
            set
            {
                _chairId = value;
            }
        } // chair_id (length: 10)
        public string SelectedStats
        {
            get { return _stats; }
            set
            {
                _oldstat = _stats;
                _stats = value;
                OnPropertyChanged("SelectedStats");
            }
        } // SelectedStats
        public string OldStat
        {
            get { return _oldstat; }
            set { _oldstat = value; }
        }//OldStat
        public int Quan
        {
            get { return _quan; }
            set
            {
                _quan = value;
                OnPropertyChanged("Quan");
            }
        } // quan
        public string Note
        {
            get { return _note; }
            set
            {
                _note = value;
                OnPropertyChanged("Note");
            }
        } // note (length: 500)

        // Foreign keys

        /// <summary>
        /// Parent Chair pointed by [OrderDetailsTemp].([ChairId]) (fk_chair_id_orderdetailtemp)
        /// </summary>
        public virtual Chair Chair { get; set; } // fk_chair_id_orderdetailtemp

        /// <summary>
        /// Parent OrderTemp pointed by [OrderDetailsTemp].([OrdertempId]) (fk_ordertemp_id_orderdetailtemp)
        /// </summary>
        public virtual OrderTemp OrderTemp { get; set; } // fk_ordertemp_id_orderdetailtemp


        public OrderDetailsTemp()
        {
            InitializePartial();
        }

        partial void InitializePartial();

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
// </auto-generated>
