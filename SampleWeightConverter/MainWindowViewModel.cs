using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter {
    public class MainWindowViewModel : ViewModel {
        private double gramValue, poundValue;

        //プロパティ
        public double GramValue {
            get { return this.gramValue; }
            set {
                this.gramValue = value;
                this.OnPropertyChanged();
            }
        }

        public double PoundValue {
            get { return this.poundValue; }
            set {
                this.poundValue = value;
                this.OnPropertyChanged();
            }
        }

        //上のComboBoxで選択されている値（単位）
        public GramUnit CurrentGramUnit { get; set; }
        //下のComboBoxで選択されている値（単位）
        public PoundUnit CurrentPoundUnit { get; set; }

        //▲ボタンで呼ばれるコマンド
        public ICommand PoundUnitToGram { get; private set; }
        //▼ボタンで呼ばれるコマンド
        public ICommand GramToPoundUnit { get; private set; }

        //コンストラクタ
        public MainWindowViewModel() {
            this.CurrentGramUnit = GramUnit.Units.First();
            this.CurrentPoundUnit = PoundUnit.Units.First();

            this.GramToPoundUnit = new DelegateCommand(
                () => this.PoundValue = this.CurrentPoundUnit.FromGramUnit(
                    this.CurrentGramUnit, this.GramValue));

            this.PoundUnitToGram = new DelegateCommand(
                () => this.GramValue = this.CurrentGramUnit.FromPoundUnit(
                    this.CurrentPoundUnit, this.PoundValue));
        }
    }
}
