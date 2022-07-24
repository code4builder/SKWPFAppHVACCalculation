using SKUWPFAppHVAC.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Media;

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

        private int _selectedRectDuctAirflow;
        public int SelectedRectDuctAirflow
        {
            get => _selectedRectDuctAirflow;
            set
            {
                _selectedRectDuctAirflow = value;
                NotifyPropertyChanged(nameof(SelectedRectDuctAirflow));
            }
        }

        private double _selectedRectDuctAirFlowLS;
        public double SelectedRectDuctAirFlowLS
        {
            get => _selectedRectDuctAirFlowLS;
            set
            {
                _selectedRectDuctAirFlowLS = value;
                NotifyPropertyChanged(nameof(SelectedRectDuctAirFlowLS));
            }
        }

        private double _rectDuctVelocity;
        public double RectDuctVelocity
        {
            get => _rectDuctVelocity;
            set
            {
                _rectDuctVelocity = value;
                NotifyPropertyChanged(nameof(RectDuctVelocity));
            }
        }

        private bool _flowInM3HRectDuctRadioButton = true;
        public bool FlowInM3HRectDuctRadioButton
        {
            get => _flowInM3HRectDuctRadioButton;
            set
            {
                _flowInM3HRectDuctRadioButton = value;
                NotifyPropertyChanged(nameof(FlowInM3HRectDuctRadioButton));
            }
        }

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

        private bool _useEquivalentDiameterChecked = false;
        public bool UseEquivalentDiameterChecked
        {
            get => _useEquivalentDiameterChecked;
            set
            {
                _useEquivalentDiameterChecked = value;
                NotifyPropertyChanged(nameof(UseEquivalentDiameterChecked));
            }
        }
        #endregion

        #region CIRCULAR DUCTS PROPERTIES

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

        private int _selectedCircDuctDiameterFromTextBox;
        public int SelectedCircDuctDiameterFromTextBox
        {
            get => _selectedCircDuctDiameterFromTextBox;
            set
            {
                _selectedCircDuctDiameterFromTextBox = value;
                NotifyPropertyChanged(nameof(SelectedCircDuctDiameterFromTextBox));
            }
        }

        private int _selectedCircDuctAirflow;
        public int SelectedCircDuctAirflow
        {
            get => _selectedCircDuctAirflow;
            set
            {
                _selectedCircDuctAirflow = value;
                NotifyPropertyChanged(nameof(SelectedCircDuctAirflow));
            }
        }

        private double _selectedCircDuctAirFlowLS;
        public double SelectedCircDuctAirFlowLS
        {
            get => _selectedCircDuctAirFlowLS;
            set
            {
                _selectedCircDuctAirFlowLS = value;
                NotifyPropertyChanged(nameof(SelectedCircDuctAirFlowLS));
            }
        }

        private double _circDuctVelocity;
        public double CircDuctVelocity
        {
            get => _circDuctVelocity;
            set
            {
                _circDuctVelocity = value;
                NotifyPropertyChanged(nameof(CircDuctVelocity));
            }
        }

        private bool _flowInM3HCircDuctRadioButton = true;
        public bool FlowInM3HCircDuctRadioButton
        {
            get => _flowInM3HCircDuctRadioButton;
            set
            {
                _flowInM3HCircDuctRadioButton = value;
                NotifyPropertyChanged(nameof(FlowInM3HCircDuctRadioButton));
            }
        }

        private bool _circDuctsManualInputChecked = false;
        public bool CircDuctsManualInputChecked
        {
            get => _circDuctsManualInputChecked;
            set
            {
                _circDuctsManualInputChecked = value;
                NotifyPropertyChanged(nameof(CircDuctsManualInputChecked));
            }
        }

        #endregion

        #region CONSTRUCTOR, DUCT LISTS AND NOTIFIER
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
        #endregion

        #region RELAY COMMANDS

        private RelayCommand showResultRectDuctVM;
        public RelayCommand ShowResultRectDuctVM
        {
            get
            {
                return showResultRectDuctVM ?? (showResultRectDuctVM = new RelayCommand(obj =>
                {
                    if (FlowInM3HRectDuctRadioButton)
                    {
                        SelectedRectDuctAirFlowLS = CalculationDucts.CalculateDuctAirflowLS(SelectedRectDuctAirflow);
                    }
                    else
                    {
                        SelectedRectDuctAirflow = CalculationDucts.CalculateDuctAirflow(SelectedRectDuctAirFlowLS);
                    }

                    if (RectDuctsManualInputChecked)
                    {
                        RectDuctVelocity = CalculationDucts.CalculateRectDuctVelocity(
                            _selectedRectDuctWidthFromTextBox,
                            _selectedRectDuctHeightFromTextBox,
                            SelectedRectDuctAirflow,
                            _useEquivalentDiameterChecked);
                        TextBoxColor = SetTextBoxColorByValue(RectDuctVelocity);
                    }
                    else
                    {
                        RectDuctVelocity = CalculationDucts.CalculateRectDuctVelocity(
                            SelectedRectDuctWidth.RectDuctSingleSize,
                            SelectedRectDuctHeight.RectDuctSingleSize,
                            SelectedRectDuctAirflow,
                            _useEquivalentDiameterChecked);
                        TextBoxColor = SetTextBoxColorByValue(RectDuctVelocity);
                    }
                }
                ));
            }
        }

        private RelayCommand showResultCircDuctVM;
        public RelayCommand ShowResultCircDuctVM
        {
            get
            {
                return showResultCircDuctVM ?? (showResultCircDuctVM = new RelayCommand(obj =>
                {
                    if (FlowInM3HCircDuctRadioButton)
                    {
                        SelectedCircDuctAirFlowLS = CalculationDucts.CalculateDuctAirflowLS(SelectedCircDuctAirflow);
                    }
                    else
                    {
                        SelectedCircDuctAirflow = CalculationDucts.CalculateDuctAirflow(SelectedCircDuctAirFlowLS);
                    }

                    if (CircDuctsManualInputChecked)
                    {
                        CircDuctVelocity = CalculationDucts.CalculateCircDuctVelocity(
                            _selectedCircDuctDiameterFromTextBox,
                            SelectedCircDuctAirflow);
                        TextBoxColor = SetTextBoxColorByValue(CircDuctVelocity);
                    }
                    else
                    {
                        CircDuctVelocity = CalculationDucts.CalculateCircDuctVelocity(
                            SelectedCircDuctSize.CircDuctSingleSize,
                            SelectedCircDuctAirflow);
                        TextBoxColor = SetTextBoxColorByValue(CircDuctVelocity);

                    }
                }
                ));
            }
        }
        #endregion

        #region SET TEXTBOX COLOR BY VELOCITY VALUE 

        private SolidColorBrush _textBoxColor;

        public SolidColorBrush TextBoxColor
        {
            get { return _textBoxColor; }
            set
            {
                _textBoxColor = value;
                NotifyPropertyChanged(nameof(TextBoxColor));
            }
        }


        private SolidColorBrush SetTextBoxColorByValue(double velocity)
        {
            if (velocity == 0)
            {
                return new SolidColorBrush(Colors.BlanchedAlmond);
            }
            else if (velocity > 0 && velocity <= 5)
            {
                return new SolidColorBrush(Colors.LightGreen);
            }
            else if (velocity > 5 && velocity <= 7)
            {
                return new SolidColorBrush(Colors.LightSalmon);
            }
            else if (velocity > 7)
            {
                return new SolidColorBrush(Colors.OrangeRed);
            }
            else
            {
                return new SolidColorBrush(Colors.BlanchedAlmond);
            }
        }
        #endregion
    }
}
