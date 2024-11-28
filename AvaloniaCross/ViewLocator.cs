using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using AvaloniaCross.ViewModels;

namespace AvaloniaCross;

public class ViewLocator : IDataTemplate
{
    /// <summary>
    /// 根据传入的参数构建对应的视图控件。
    /// </summary>
    /// <param name="param">视图模型对象，用于确定要构建的视图类型。</param>
    /// <returns>构建的视图控件，如果找不到对应的视图类型，则返回一个显示“Not Found”的TextBlock。</returns>
    public Control? Build(object? param)
    {
        if (param is null)
            return null;

        var name = param.GetType().FullName!.Replace("ViewModel", "View", StringComparison.Ordinal);
        var type = Type.GetType(name);

        if (type != null)
        {
            return (Control)Activator.CreateInstance(type)!;
        }

        return new TextBlock { Text = "Not Found: " + name };
    }

    public bool Match(object? data)
    {
        return data is ViewModelBase;
    }
}