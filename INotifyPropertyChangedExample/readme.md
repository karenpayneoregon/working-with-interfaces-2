# About

Simple code sample for [INotifyPropertyChanged](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.inotifypropertychanged?view=net-6.0). 

When a change is made for a property the client is notified and in turn updates any data bindings.

Here ProductName is setup for change notification.

```csharp
    public class Product : INotifyPropertyChanged
    {
        private string _productName;
        public string ProductName
        {
            get => _productName;
            set
            {
                _productName = value;
                OnPropertyChanged();
            }
        }
```

Here we implment required events

```csharp
public event PropertyChangedEventHandler PropertyChanged;
protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
{
    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
```

Because of [CallerMemberName](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.callermembernameattribute?view=net-6.0) need not pass the property name from `OnPropertyChanged`.

# Try it out

1. Run this application
2. Make a change to one or more properties on a row in the DataGridView
3. Click the `Current` button and check out the changes in Visual Studio output window. Also after the application has loaded data, set a breakpoint on ProductName, change a value and we hit the breakpoint because of change notification this than goes and notifies the client of the change.