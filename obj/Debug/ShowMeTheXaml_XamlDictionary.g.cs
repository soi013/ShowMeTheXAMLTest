
using System.Collections.Generic;

namespace ShowMeTheXAML
{
    public static class XamlDictionary
    {
        static XamlDictionary()
        {
            XamlResolver.Set("Unique1", @"<smtx:XamlDisplay Key=""Unique1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Button Content=""Some Content"" />
    <!--  コメントも表示される  -->
    <TextBlock Text=""Some Text"" />
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("Unique2", @"<smtx:XamlDisplay Key=""Unique2"" Padding=""5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Grid Width=""300"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Grid.ColumnDefinitions>
      <ColumnDefinition Width=""Auto"" />
      <ColumnDefinition Width=""*"" />
    </Grid.ColumnDefinitions>
    <Grid.RowDefinitions>
      <RowDefinition Height=""Auto"" />
      <RowDefinition />
      <RowDefinition Height=""Auto"" />
    </Grid.RowDefinitions>
    <Menu Grid.Row=""0"" Grid.ColumnSpan=""2"">
      <MenuItem Header=""File"" />
      <MenuItem Header=""Edit"" />
    </Menu>
    <CheckBox Grid.Row=""1"" Grid.Column=""0"" Content=""Some Text1"" />
    <Calendar Grid.Row=""1"" Grid.Column=""1"" />
    <Button Grid.Row=""2"" Grid.ColumnSpan=""2"" Content=""BUTTON"" />
  </Grid>
</smtx:XamlDisplay>");
XamlResolver.Set("Unique3", @"<smtx:XamlDisplay Key=""Unique3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
                AAAA
            </smtx:XamlDisplay>");
XamlResolver.Set("Unique4-1", @"<smtx:XamlDisplay Key=""Unique4-1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TextBlock Text=""4-1"" />
    <smtx:XamlDisplay Key=""4-2"">
      <StackPanel>
        <TextBlock Text=""4-2"" />
        <smtx:XamlDisplay Key=""Unique4-3"">
          <StackPanel>
            <TextBlock Text=""4-3"" />
            <smtx:XamlDisplay Key=""Unique4-4"">
              <TextBlock Text=""4-4"" />
            </smtx:XamlDisplay>
          </StackPanel>
        </smtx:XamlDisplay>
      </StackPanel>
    </smtx:XamlDisplay>
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("4-2", @"<smtx:XamlDisplay Key=""4-2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TextBlock Text=""4-2"" />
    <smtx:XamlDisplay Key=""Unique4-3"">
      <StackPanel>
        <TextBlock Text=""4-3"" />
        <smtx:XamlDisplay Key=""Unique4-4"">
          <TextBlock Text=""4-4"" />
        </smtx:XamlDisplay>
      </StackPanel>
    </smtx:XamlDisplay>
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("Unique4-3", @"<smtx:XamlDisplay Key=""Unique4-3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TextBlock Text=""4-3"" />
    <smtx:XamlDisplay Key=""Unique4-4"">
      <TextBlock Text=""4-4"" />
    </smtx:XamlDisplay>
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("Unique4-4", @"<smtx:XamlDisplay Key=""Unique4-4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBlock Text=""4-4"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("Unique5", @"<smtx:XamlDisplay Key=""Unique5"" Style=""{StaticResource NoFormatter}"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <local:UserControl1 xmlns:local=""clr-namespace:ShowMeTheXAMLTest"" />
    <Label>
      <system:Double xmlns:system=""clr-namespace:System;assembly=mscorlib"">123</system:Double>
    </Label>
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("Unique6", @"<smtx:XamlDisplay Key=""Unique6"" Formatter=""{StaticResource xamlFormatter}"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <local:UserControl1 xmlns:local=""clr-namespace:ShowMeTheXAMLTest"" />
    <Label>
      <system:Double xmlns:system=""clr-namespace:System;assembly=mscorlib"">123</system:Double>
    </Label>
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("Unique8", @"<smtx:XamlDisplay Key=""Unique8"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TextBlock x:Name=""tb1"" Text=""Some Text1"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" />
    <Button Click=""Button_Click"" Content=""BUTTON"" />
  </StackPanel>
</smtx:XamlDisplay>");
        }
    }
}