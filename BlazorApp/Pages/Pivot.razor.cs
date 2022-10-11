using Syncfusion.Blazor.PivotView;
namespace BlazorApp.Pages
{
    public partial class Pivot
    {
        private List<PlaceholderDsvCarPivot>? _dataSource;
        private string? _pivotHeight;
        private string? _pivotWidth;
        private SfPivotView<PlaceholderDsvCarPivot>? _pivot;

        protected override async Task OnInitializedAsync()
        {
            _pivotHeight = "1200";            
            _pivotWidth = "1200";
            _dataSource = DataSource.DemoData;
        }

        public void OnExcelExport(Microsoft.AspNetCore.Components.Web.MouseEventArgs args)
        {
            _pivot?.ExportToExcelAsync();            
        }
    }

    public class DataSource
    {
        public static List<PlaceholderDsvCarPivot>? DemoData =>

            new List<PlaceholderDsvCarPivot>
            {
                new PlaceholderDsvCarPivot{Beløb = 10,Bil = "A", Dato = new DateTime(2022,1,1), Periode = "2022-1"},
                new PlaceholderDsvCarPivot{Beløb = 20,Bil = "A", Dato = new DateTime(2022,1,2), Periode = "2022-1"},
                new PlaceholderDsvCarPivot{Beløb = 30,Bil = "A", Dato = new DateTime(2022,1,3), Periode = "2022-1"},
                new PlaceholderDsvCarPivot{Beløb = 10,Bil = "B", Dato = new DateTime(2022,1,1), Periode = "2022-1"},
                new PlaceholderDsvCarPivot{Beløb = 20,Bil = "B", Dato = new DateTime(2022,1,2), Periode = "2022-1"}
            };
    } 

    public class PlaceholderDsvCarPivot
    {
        public string? Periode { get; set; }
        public decimal Beløb{ get; set; }
        public string? Bil { get; set; }
        public DateTime? Dato { get; set; }
    }
}