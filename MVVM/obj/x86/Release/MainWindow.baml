   M S B A M L   `   `   `  ���� ?  ;MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MVVM.TwitterMVVM.Twitter      MVVM.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     0	namespaceclr-namespace:MVVM.Twitter       � Title$  Twitter��$	��421��$	��909��.��� .+��� -    ��Name$ Tweets��$
��Left=�$	��549��
����������� *Tweets+ �� SelectedItem �� *SelectedTweet+���� .R��  � RowDefinitions �� $��50 ��� $��* ��� $��* � � ColumnDefinitions �� $��* ��� $	��450 �.+��� $��50��$��0��$��0��$��50��$��Center=�����  �� Path$ user.profile_image_url��� $��0��$��1��$��Center=�$��10(����� $ user.screen_name��� $��0��$��1��$
��Wrap=�$	��Top=����� $
 text��� $��0��$��1��$��Bottom=����� $ 
created_at��� -   $��listBox1��$	��382��$
��Left=�$��	547,0,0,0q�$	��Top=�$	��353��
��������� $	��382��$��Center=�$��547,0,-13,0q�$
��Fill=����� $ CurrentImageFromTweet�