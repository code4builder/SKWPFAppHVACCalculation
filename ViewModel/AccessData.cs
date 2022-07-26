using SKUWPFAppHVAC.Model;
using SKUWPFAppHVAC.Model.Calculations;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Media;

namespace SKUWPFAppHVAC.ViewModel
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

        #region HEATING POWER FOR AIRFLOW
        private double _selectedAirflowForHeating;
        public double SelectedAirflowForHeating
        {
            get => _selectedAirflowForHeating;
            set
            {
                _selectedAirflowForHeating = value;
                NotifyPropertyChanged(nameof(SelectedAirflowForHeating));
            }
        }

        private double _selectedInletAirTemperatureForHeating;
        public double SelectedInletAirTemperatureForHeating
        {
            get => _selectedInletAirTemperatureForHeating;
            set
            {
                _selectedInletAirTemperatureForHeating = value;
                NotifyPropertyChanged(nameof(SelectedInletAirTemperatureForHeating));
            }
        }

        private double _selectedOutletAirTemperatureForHeating;
        public double SelectedOutletAirTemperatureForHeating
        {
            get => _selectedOutletAirTemperatureForHeating;
            set
            {
                _selectedOutletAirTemperatureForHeating = value;
                NotifyPropertyChanged(nameof(SelectedOutletAirTemperatureForHeating));
            }
        }

        private double _heatingPowerForAirflow;
        public double HeatingPowerForAirflow
        {
            get => _heatingPowerForAirflow;
            set
            {
                _heatingPowerForAirflow = value;
                NotifyPropertyChanged(nameof(HeatingPowerForAirflow));
            }
        }

        #endregion

        #region PIPE WATER FLOW PROPERTIES

        private double _selectedPower;
        public double SelectedPower
        {
            get => _selectedPower;
            set
            {
                _selectedPower = value;
                NotifyPropertyChanged(nameof(SelectedPower));
            }
        }

        private double _selectedTemperatureSupply;
        public double SelectedTemperatureSupply
        {
            get => _selectedTemperatureSupply;
            set
            {
                _selectedTemperatureSupply = value;
                NotifyPropertyChanged(nameof(SelectedTemperatureSupply));
            }
        }

        private double _selectedTemperatureReturn;
        public double SelectedTemperatureReturn
        {
            get => _selectedTemperatureReturn;
            set
            {
                _selectedTemperatureReturn = value;
                NotifyPropertyChanged(nameof(SelectedTemperatureReturn));
            }
        }

        private bool _pipePowerInputCheckBox = true;
        public bool PipePowerInputCheckBox
        {
            get => _pipePowerInputCheckBox;
            set
            {
                _pipePowerInputCheckBox = value;
                NotifyPropertyChanged(nameof(PipePowerInputCheckBox));
            }
        }

        private int _selectedPipeSize;
        public int SelectedPipeSize
        {
            get => _selectedPipeSize;
            set
            {
                _selectedPipeSize = value;
                NotifyPropertyChanged(nameof(SelectedPipeSize));
            }
        }

        private double _selectedPipeSizeFromTextBox;
        public double SelectedPipeSizeFromTextBox
        {
            get => _selectedPipeSizeFromTextBox;
            set
            {
                _selectedPipeSizeFromTextBox = value;
                NotifyPropertyChanged(nameof(SelectedPipeSizeFromTextBox));
            }
        }

        private bool _pipeDiameterManualInputChecked = false;
        public bool PipeDiameterManualInputChecked
        {
            get => _pipeDiameterManualInputChecked;
            set
            {
                _pipeDiameterManualInputChecked = value;
                NotifyPropertyChanged(nameof(PipeDiameterManualInputChecked));
            }
        }

        private bool _flowInM3HPipeRadioButton = true;
        public bool FlowInM3HPipeRadioButton
        {
            get => _flowInM3HPipeRadioButton;
            set
            {
                _flowInM3HPipeRadioButton = value;
                NotifyPropertyChanged(nameof(FlowInM3HPipeRadioButton));
            }
        }

        private bool _flowInKgHPipeRadioButton = false;
        public bool FlowInKgHPipeRadioButton
        {
            get => _flowInKgHPipeRadioButton;
            set
            {
                _flowInKgHPipeRadioButton = value;
                NotifyPropertyChanged(nameof(FlowInKgHPipeRadioButton));
            }
        }

        private bool _flowInLSPipeRadioButton = false;
        public bool FlowInLSPipeRadioButton
        {
            get => _flowInLSPipeRadioButton;
            set
            {
                _flowInLSPipeRadioButton = value;
                NotifyPropertyChanged(nameof(FlowInLSPipeRadioButton));
            }
        }

        private double _selectedFlowM3H;
        public double SelectedFlowM3H
        {
            get => _selectedFlowM3H;
            set
            {
                _selectedFlowM3H = value;
                NotifyPropertyChanged(nameof(SelectedFlowM3H));
            }
        }

        private double _selectedFlowKgH;
        public double SelectedFlowKgH
        {
            get => _selectedFlowKgH;
            set
            {
                _selectedFlowKgH = value;
                NotifyPropertyChanged(nameof(SelectedFlowKgH));
            }
        }

        private double _selectedFlowLS;
        public double SelectedFlowLS
        {
            get => _selectedFlowLS;
            set
            {
                _selectedFlowLS = value;
                NotifyPropertyChanged(nameof(SelectedFlowLS));
            }
        }

        private double _flowVelocity;
        public double FlowVelocity
        {
            get => _flowVelocity;
            set
            {
                _flowVelocity = value;
                NotifyPropertyChanged(nameof(FlowVelocity));
            }
        }

        private string _commentFlowVelocity;
        public string CommentFlowVelocity
        {
            get => _commentFlowVelocity;
            set
            {
                _commentFlowVelocity = value;
                NotifyPropertyChanged(nameof(CommentFlowVelocity));
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
            PipeSizeList = new List<int>()
            {
                15, 20, 25, 32, 40, 50, 65, 80, 100, 125, 150, 200, 250, 300, 350, 400, 450, 500
            };

            SelectedRectDuctWidth = RectDuctsSizesList.First();
            SelectedRectDuctHeight = RectDuctsSizesList.First();
            SelectedCircDuctSize = CircDuctsSizesList.First();
            SelectedPipeSize = PipeSizeList.First();
        }

        public List<RectDuctsSize> RectDuctsSizesList { get; }
        public List<CircDuctsSize> CircDuctsSizesList { get; }

        public List<int> PipeSizeList { get; }

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
                        TextBoxColor = SetTextBoxColorByValue(RectDuctVelocity, 5, 7);
                    }
                    else
                    {
                        RectDuctVelocity = CalculationDucts.CalculateRectDuctVelocity(
                            SelectedRectDuctWidth.RectDuctSingleSize,
                            SelectedRectDuctHeight.RectDuctSingleSize,
                            SelectedRectDuctAirflow,
                            _useEquivalentDiameterChecked);
                        TextBoxColor = SetTextBoxColorByValue(RectDuctVelocity, 5, 7);
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
                        TextBoxColor = SetTextBoxColorByValue(CircDuctVelocity, 5, 7);
                    }
                    else
                    {
                        CircDuctVelocity = CalculationDucts.CalculateCircDuctVelocity(
                            SelectedCircDuctSize.CircDuctSingleSize,
                            SelectedCircDuctAirflow);
                        TextBoxColor = SetTextBoxColorByValue(CircDuctVelocity, 5, 7);
                    }
                }
                ));
            }
        }

        private RelayCommand _showResultHeatingPowerForAirflowVM;
        public RelayCommand ShowResultHeatingPowerForAirflowVM
        {
            get
            {
                return _showResultHeatingPowerForAirflowVM ?? (_showResultHeatingPowerForAirflowVM = new RelayCommand(obj =>
                {
                    HeatingPowerForAirflow = CalculationDucts.CalculateHeatingPowerForAirflow(
                        SelectedAirflowForHeating, 
                        SelectedInletAirTemperatureForHeating,
                        SelectedOutletAirTemperatureForHeating);
                }
                ));
            }
        }


        private RelayCommand showResultWaterFlowVM;
        public RelayCommand ShowResultWaterFlowVM
        {
            get
            {
                return showResultWaterFlowVM ?? (showResultWaterFlowVM = new RelayCommand(obj =>
                {
                    if (PipePowerInputCheckBox)
                    {
                        SelectedFlowM3H = CalculationPipes.CalculateFlowFromByPower(SelectedPower, SelectedTemperatureSupply, SelectedTemperatureReturn).Item1;
                        SelectedFlowKgH = CalculationPipes.CalculateFlowFromByPower(SelectedPower, SelectedTemperatureSupply, SelectedTemperatureReturn).Item2;
                        SelectedFlowLS = CalculationPipes.CalculateFlowFromByPower(SelectedPower, SelectedTemperatureSupply, SelectedTemperatureReturn).Item3;

                        if (PipeDiameterManualInputChecked)
                        {
                            FlowVelocity = CalculationPipes.CalculateWaterVelocity(SelectedPipeSizeFromTextBox, SelectedFlowM3H);
                            TextBoxColor = SetTextBoxColorByValue(FlowVelocity, 1, 1.5);
                        }
                        else
                        {
                            FlowVelocity = CalculationPipes.CalculateWaterVelocity(SelectedPipeSize, SelectedFlowM3H);
                            TextBoxColor = SetTextBoxColorByValue(FlowVelocity, 1, 1.5);
                        }

                        CommentFlowVelocity = CalculationPipes.CheckVelocityValue(FlowVelocity);
                    }
                    else
                    {
                        if (FlowInM3HPipeRadioButton)
                        {
                            SelectedFlowKgH = CalculationPipes.CalculateFlowByKnownM3H(SelectedFlowM3H).Item1;
                            SelectedFlowLS = CalculationPipes.CalculateFlowByKnownM3H(SelectedFlowM3H).Item2;
                        }
                        else if (FlowInKgHPipeRadioButton)
                        {
                            SelectedFlowM3H = CalculationPipes.CalculateFlowByKnownKgH(SelectedFlowKgH).Item1;
                            SelectedFlowLS = CalculationPipes.CalculateFlowByKnownKgH(SelectedFlowKgH).Item2;
                        }
                        else
                        {
                            SelectedFlowM3H = CalculationPipes.CalculateFlowByKnownLS(SelectedFlowLS).Item1;
                            SelectedFlowKgH = CalculationPipes.CalculateFlowByKnownLS(SelectedFlowLS).Item2;
                        }

                        if (PipeDiameterManualInputChecked)
                        {
                            FlowVelocity = CalculationPipes.CalculateWaterVelocity(SelectedPipeSizeFromTextBox, SelectedFlowM3H);
                            TextBoxColor = SetTextBoxColorByValue(FlowVelocity, 1, 1.5);
                            CommentFlowVelocity = CalculationPipes.CheckVelocityValue(FlowVelocity);
                        }
                        else
                        {
                            FlowVelocity = CalculationPipes.CalculateWaterVelocity(SelectedPipeSize, SelectedFlowM3H);
                            TextBoxColor = SetTextBoxColorByValue(FlowVelocity, 1, 1.5);
                            CommentFlowVelocity = CalculationPipes.CheckVelocityValue(FlowVelocity);
                        }
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


        private SolidColorBrush SetTextBoxColorByValue(double velocity, double lowVelocity, double normalVelocity)
        {
            if (velocity == 0)
            {
                return new SolidColorBrush(Colors.BlanchedAlmond);
            }
            else if (velocity <= lowVelocity)
            {
                return new SolidColorBrush(Colors.LightGreen);
            }
            else if (velocity > lowVelocity && velocity <= normalVelocity)
            {
                return new SolidColorBrush(Colors.LightSalmon);
            }
            else if (velocity > normalVelocity)
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
