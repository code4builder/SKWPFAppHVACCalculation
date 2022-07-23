using SKUWPFAppHVAC.Data.Calculations;
using SKUWPFAppHVAC.Data.Content.ListsData;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;

namespace SKUWPFAppHVAC.Data
{
    internal class AccessData : INotifyPropertyChanged
    {
        #region RECTANGULAR DUCTS PROPERTIES

        private RectDuctsSize _selectedRectDuctWidth;

        public RectDuctsSize SelectedRectDuctWidth
        {
            get => _selectedRectDuctWidth;
            set
            {
                _selectedRectDuctWidth = value;
                NotifyPropertyChanged(nameof(SelectedRectDuctWidth));
            }
        }

        private RectDuctsSize _selectedRectDuctHeight;

        public RectDuctsSize SelectedRectDuctHeight
        {
            get => _selectedRectDuctHeight;
            set
            {
                _selectedRectDuctHeight = value;
                NotifyPropertyChanged(nameof(SelectedRectDuctHeight));
            }
        }

        private int _selectedRectDuctWidthFromTextBox;

        public int SelectedRectDuctWidthFromTextBox
        {
            get => _selectedRectDuctWidthFromTextBox;
            set
            {
                _selectedRectDuctWidthFromTextBox = value;
                NotifyPropertyChanged(nameof(SelectedRectDuctWidthFromTextBox));
            }
        }

        private int _selectedRectDuctHeightFromTextBox;

        public int SelectedRectDuctHeightFromTextBox
        {
            get => _selectedRectDuctHeightFromTextBox;
            set
            {
                _selectedRectDuctHeightFromTextBox = value;
                NotifyPropertyChanged(nameof(SelectedRectDuctHeightFromTextBox));
            }
        }

        private CircDuctsSize _selectedCircDuctSize;

        public CircDuctsSize SelectedCircDuctSize
        {
            get => _selectedCircDuctSize;
            set
            {
                _selectedCircDuctSize = value;
                NotifyPropertyChanged(nameof(SelectedCircDuctSize));
            }
        }

        private int _selectedAirflow;

        public int SelectedAirflow
        {
            get => _selectedAirflow;
            set
            {
                _selectedAirflow = value;
                NotifyPropertyChanged(nameof(SelectedAirflow));
            }
        }

        private double _selectedAirFlowLS;

        public double SelectedAirFlowLS
        {
            get => _selectedAirFlowLS;
            set
            {
                _selectedAirFlowLS = value;
                NotifyPropertyChanged(nameof(SelectedAirFlowLS));
            }
        }

        private double _velocity;

        public double Velocity
        {
            get => _velocity;
            set
            {
                _velocity = value;
                NotifyPropertyChanged(nameof(Velocity));
            }
        }

        private bool _flowInM3HRadioButton = true;

        public bool FlowInM3HRadioButton
        {
            get => _flowInM3HRadioButton;
            set
            {
                _flowInM3HRadioButton = value;
                NotifyPropertyChanged(nameof(FlowInM3HRadioButton));
            }
        }
        #endregion

        private bool _rectDuctsManualInputChecked = false;

        public bool RectDuctsManualInputChecked
        {
            get => _rectDuctsManualInputChecked;
            set
            {
                _rectDuctsManualInputChecked = value;
                NotifyPropertyChanged(nameof(RectDuctsManualInputChecked));
            }
        }


        public AccessData()
        {
            //Creating of Size List for Rectangular Ducts
            RectDuctsSizesList = new List<RectDuctsSize>();
            for (int i = 100; i < 1501; i += 50)
            {
                RectDuctsSizesList.Add(new RectDuctsSize(i));
            }

            //Creating of Size List for Circular Ducts
            CircDuctsSizesList = new List<CircDuctsSize>
            {
                new CircDuctsSize(100),
                new CircDuctsSize(125),
                new CircDuctsSize(160),
                new CircDuctsSize(200),
                new CircDuctsSize(250),
                new CircDuctsSize(315),
                new CircDuctsSize(355),
                new CircDuctsSize(400),
                new CircDuctsSize(450),
                new CircDuctsSize(500),
                new CircDuctsSize(550),
                new CircDuctsSize(630),
                new CircDuctsSize(710),
                new CircDuctsSize(800),
                new CircDuctsSize(900),
                new CircDuctsSize(1000)
            };
            SelectedRectDuctWidth = RectDuctsSizesList.First();
            SelectedRectDuctHeight = RectDuctsSizesList.First();
            SelectedCircDuctSize = CircDuctsSizesList.First();
        }

        public List<RectDuctsSize> RectDuctsSizesList { get; }
        public List<CircDuctsSize> CircDuctsSizesList { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private RelayCommand showResultVM;
        public RelayCommand ShowResultVM
        {
            get
            {
                return showResultVM ?? (showResultVM = new RelayCommand(obj =>
                {
                    if (RectDuctsManualInputChecked)
                    {
                        //SelectedRectDuctWidth.RectDuctSingleSize = _selectedRectDuctWidthFromTextBox;
                        //SelectedRectDuctHeight.RectDuctSingleSize = _selectedRectDuctHeightFromTextBox;

                        if (FlowInM3HRadioButton)
                        {
                            SelectedAirFlowLS = CalculationDucts.CalculateDuctAirflowLS(SelectedAirflow);

                            Velocity = CalculationDucts.CalculateRectDuctVelocity(
                                _selectedRectDuctWidthFromTextBox,
                                _selectedRectDuctHeightFromTextBox,
                                SelectedAirflow);
                        }
                        else
                        {
                            SelectedAirflow = CalculationDucts.CalculateDuctAirflow(SelectedAirFlowLS);
                            Velocity = CalculationDucts.CalculateRectDuctVelocity(
                                _selectedRectDuctWidthFromTextBox,
                                _selectedRectDuctHeightFromTextBox,
                                SelectedAirflow);
                        }
                    }
                    else
                    {
                        if (FlowInM3HRadioButton)
                        {
                            SelectedAirFlowLS = CalculationDucts.CalculateDuctAirflowLS(SelectedAirflow);

                            Velocity = CalculationDucts.CalculateRectDuctVelocity(
                                SelectedRectDuctWidth.RectDuctSingleSize,
                                SelectedRectDuctHeight.RectDuctSingleSize,
                                SelectedAirflow);
                        }
                        else
                        {
                            SelectedAirflow = CalculationDucts.CalculateDuctAirflow(SelectedAirFlowLS);
                            Velocity = CalculationDucts.CalculateRectDuctVelocity(
                                SelectedRectDuctWidth.RectDuctSingleSize,
                                SelectedRectDuctHeight.RectDuctSingleSize,
                                SelectedAirflow);
                        }
                    }
                }
                ));
            }
        }


    }
}
