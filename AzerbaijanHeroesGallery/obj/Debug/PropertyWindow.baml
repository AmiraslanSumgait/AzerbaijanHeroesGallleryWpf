   M S B A M L   `   `   `  ����R  NAzerbaijanHeroesGallery, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:AzerbaijanHeroesGalleryAzerbaijanHeroesGallery  5   	   ,    &AzerbaijanHeroesGallery.PropertyWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:AzerbaijanHeroesGallery     5   	   -   5          � Title$  PropertyWindow��5   	   $	��450��6    $	��800��6-    � 
ResizeMode$ NoResize=�6;    � WindowStyle$
 None=�5	   	    � WindowStartupLocation$ CenterOwner=�5
   	   .��5      �    SpecialGradient#��[  6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��4* �6   �� 5      $
��1.5* �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        
������ $��40��5      $��0q�5        withoutMouseOver#���  5      .��5      �� $��Images/back (2).png��6   5      5      �� 5      -   5        $��
nameTxtBlk��5      $	��620��5      $��30(�5      $��10,0,0,0q�5        RedGradientBrush#��[ 5       5!      �� 5"      -   5        $��
dateTxtBlk��5"      $	��120��5#      $��25(�5$        CyanGradientBrush#��[ 5%      $��Bottom=�5&      5(      5)      �� 5*   
   -   5         ��Name$ 	mainImage��5*      $��1��5+      6   �� 5,   
   $��2��6   $ 
Horizontal=�5-      .+�5/      �� -   5         ��Name$ descriptionTxtb��5/      $	��650��50      $
��Wrap=�51      $��16(�52      $��5,0,0,0q�53      #��[ 54      56      �� 57      -   5        $ 	priceTxtb��57      $��18(�58      $
��auto��59      $��20,0,0,0q�5:        OrangeGradientBrush#��[ 5;      $��Bottom=�5<      65   5=      �� 5>   
   $��3��6   $ 
Horizontal=�5?      $��Center=�5@      .+�5A      �� -   5         ��Name$ prevBtn��5A      $��50��5B      $��10q�5C      $
��Prev��5D        BlueGradientBrush#��[ 5E      $��Center=�5F      $��Center=�5G        ButtonStyle#���  5H      5I   -   �� 5J      -	   5        $ pauseBtn��5J      $��50��5K      $��10q�5L      $��Pause��5M      #��[ 5N      $��Center=�5O      $��Center=�5P      #���  5Q      5R   .   �� 5S      -
   5        $ autoPlayBtn��5S      $��50��5T      $��10q�5U      $
��Play��5V      #��[ 5W      $��Center=�5X      $��Center=�5Y      #���  5Z      5\      �� 5]      -   5        $ nextBtn��5]      $��50��5^      $��10q�5_      $
��Next��5`      #��[ 5a      $��Center=�5b      $��Center=�5c      #���  5d      5f      5g      5h      5i      