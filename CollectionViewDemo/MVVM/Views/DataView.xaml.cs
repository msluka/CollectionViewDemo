using CollectionViewDemo.MVVM.ViewModels;
using System.Diagnostics;

namespace CollectionViewDemo.MVVM.Views;

public partial class DataView : ContentPage
{
	public DataView()
	{
		InitializeComponent();
		BindingContext = new DataViewModel();
	}

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var element_list = e.CurrentSelection;
        var i = element_list.Count() - 1;
        var name = (element_list[i] as Models.Product).Name;
        Debug.WriteLine(name);

    }

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
        var isToggled = e.Value;
        collectionView.EmptyView = isToggled ? Resources["NoResultsView"] : Resources["ConnectionErrorView"];
    }

    //  private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    //  {
    //var element = e.CurrentSelection;
    //var name = (element.FirstOrDefault() as Models.Product).Name;
    //Debug.WriteLine(name);		

    //  }
}