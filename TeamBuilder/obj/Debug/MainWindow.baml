   M S B A M L   `   `   `  ����F  BTeamBuilder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TeamBuilderTeamBuilder  5   	       TeamBuilder.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:TeamBuilder     5   	     � Title$  
MainWindow��5   	   $	��400��6   $	��600��6)    � WindowStartupLocation$ CenterScreen=�65   .��5	      � .+�5
   
   �� -   5        $��Display Teams��5
      $
��Left=�6)   $��375,100,0,0q�6D   $	��Top=�6Y   $	��125��6q   $��30��6�   �� 5   
   -   5        $��Add Name��5      $
��Left=�6$   $��30��6?   $��375,150,0,0q�6K   $	��Top=�6`   $	��125��6x   6�   �� 5   
   -   5        $��Remove Name��5      $
��Left=�6'   $	��Top=�6B   $	��125��6Z   $��375,200,0,0q�6f   $��30��6{   6�   �� 5   
   -   5         ��Name$ cbNames��5      $
��Left=�6$   $	��Top=�6?   $	��125��6W   $��225,200,0,0q�6c   $��30��6x   �� 5   
   -   5         ��Name$ 	tbNewName��5      $
��Left=�6%   $��30��6@    �� TextWrapping$
 Wrap=�6L   $�� ��6`   $	��Top=�6h   $	��125��6�   $��225,150,0,0q�6�   �� 5   
   -   5        $��Create Teams��5      $
��Left=�6(   $	��Top=�6C   $	��125��6[   $��225,100,0,0q�6g   $��30��6|   6�   �� 5   
   -   5        $��
Save Names��5      $
��Left=�6&   $	��Top=�6A   $	��125��6Y   $��225,315,0,0q�6e   $��30��6z   6�   �� 5   
   -   5        $��
Load Names��5      $
��Left=�6&   $	��Top=�6A   $	��125��6Y   $��375,315,0,0q�6e   $��30��6z   6�   �� 5   
   -	   5        $ 
tbFileName��5      $
��Left=�6&   $��30��6A   $
 Wrap=�6M   $	��Top=�6a   $	��125��6y   $��
75,315,0,0q�6�   5      5      