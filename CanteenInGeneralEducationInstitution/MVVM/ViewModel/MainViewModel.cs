using CanteenInGeneralEducationInstitution.Core;
using System;


namespace CanteenInGeneralEducationInstitution.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        //user
        public RelayCommand DishesViewCommand { get; set; }
        public RelayCommand AccountViewCommand { get; set; }

        public RelayCommand BasketViewCommand { get; set; }

        public DishesViewModel DishesVM { get; set; }
        public AccountViewModel AcountVM { get; set; }

        public BasketViewModel BasketVM { get; set; }

        //admin

        public RelayCommand EmployeeViewCommand { get; set; }
        public RelayCommand StudentViewCommand { get; set; }
        public RelayCommand DinningRoomViewCommand { get; set; }
        public RelayCommand SupplyViewCommand { get; set; }
        public RelayCommand BuffetViewCommand { get; set; }
        public RelayCommand SaleViewCommand { get; set; }
        public SaleViewModel SaleVM { get; set; }
        public BuffetViewModel BuffetVM { get; set; }
        public SupplyViewModel SupplyVM { get; set; }
        public DinningRoomViewModel DinningRoomVM { get; set; }
        public EmployeeViewModel EmployeeVM { get; set; }
        public StudentViewModel StudentVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            AcountVM = new AccountViewModel();
            DishesVM = new DishesViewModel();
            BasketVM = new BasketViewModel();
            EmployeeVM = new EmployeeViewModel();
            StudentVM = new StudentViewModel();
            DinningRoomVM = new DinningRoomViewModel();
            SupplyVM = new SupplyViewModel();
            BuffetVM = new BuffetViewModel();
            SaleVM = new SaleViewModel();

            CurrentView = AcountVM;

            DishesViewCommand = new RelayCommand(o =>
            {
                CurrentView = DishesVM;
            });

            AccountViewCommand = new RelayCommand(o =>
            {
                CurrentView = AcountVM;
            });

            BasketViewCommand = new RelayCommand(o =>
            {
                CurrentView = BasketVM;
            });

            EmployeeViewCommand = new RelayCommand(o =>
            {
                CurrentView = EmployeeVM;
            });

            StudentViewCommand = new RelayCommand(o =>
            {
                CurrentView = StudentVM;
            });

            DinningRoomViewCommand = new RelayCommand(o =>
            {
                CurrentView = DinningRoomVM;
            });

            SupplyViewCommand = new RelayCommand(o =>
            {
                CurrentView = SupplyVM;
            });

            BuffetViewCommand = new RelayCommand(o =>
            {
                CurrentView = BuffetVM;
            });

            SaleViewCommand = new RelayCommand(o =>
            {
                CurrentView = SaleVM;
            });
        }
    }
}
