   M S B A M L   `   `   `  ����?  ;MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MVVM.TwitterMVVM.Twitter  5   	       MVVM.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   0	namespaceclr-namespace:MVVM.Twitter     5   	     � Title$  Twitter��5   	   $	��489��6   $	��909��6&   .��5      � 
�������.+�5   
   �� -   5         ��Name$ Tweets��5   X   $
��Left=�6h   $	��549��6�   
�������$��0,0,0,67q�6�   ��6   �� *Tweets+ �� SelectedItem 61   �� *SelectedTweet+��5      �� 5	      .R�5
      �  � RowDefinitions 5      �� 5      $��50 �6,   �� 5      $��* �6,   �� 5      $��* �6,    � ColumnDefinitions 5      �� 5      $��* �6/   �� 5      $	��450 �6/   .+�5      �� $��50��6    $��0��6+   $��0��6;   $��50��6H   $��Center=�6�   ��6T   ��  �� Path$ user.profile_image_url�6�   �� 5      $��0��6$   $��1��64   $��Center=�6h   $��10(�6�   ��6A   �� $ user.screen_name�6�   �� 5      $��0��6$   $��1��61   $
��Wrap=�6\   $	��Top=�6p   ��6A   �� $
 text�6p   �� 5      $��0��6$   $��1��61   $��Bottom=�6b   ��6A   �� $ 
created_at�6b   5      5      5      �� 5   
   -   5        $��listBox1��5   M   $	��383��6   $
��Left=�6   $��	547,0,0,0q�6:   $	��Top=�6]   $	��353��6u   
�������6�   �� 5   
   $	��400��6   $��Center=�6K   $��547,0,-13,50q�6f   $
��Fill=�6|   ��6   �� $ CurrentImageFromTweet�6|   �� 5   
   -   5        $��TextUpdateTweets��5   �   $��23��6   $��Center=�6g   $��192,410,0,0q�6�   $	��Top=�6�   $	��169��6�   ��6   �� *CurrentTwitterUser+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   -   5        $��Update��5      $��23��6"   $��Center=�6.   $��380,410,0,0q�6K   $	��Top=�6`   $��75��6x   6�   5       5!      