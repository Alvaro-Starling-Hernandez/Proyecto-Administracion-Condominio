   M S B A M L   `   `   `  ����M  IProyectoCondominio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ProyectoCondominioProyectoCondominio  5   	       ProyectoCondominio.Login   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:ProyectoCondominio     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	   
������� � Icon$ /Resources/Icono.ico��5   	    � Title$ Login��5   	   $	��259��6   $	��359��6$    � 
ResizeMode$ NoResize=�60    � WindowStyle$
 None=�6F    � WindowStartupLocation$ CenterScreen=�6Y   .��5      � .+�5   
   �� $	��280��6   .+�5      �� $��Iniciar Sesion��6   $��22(�6/   $
��0,10q�6=   $	��Top=�6K   $��Center=�6c   �� 5      $
��0,15q�6    �� Orientation$ 
Horizontal=�6'   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Account=�6*   $��Center=�69   ���#7070706T   �� 5      -   5        	 ��Name$	 NombreUsuarioTextBox��5   d   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Nombre de Usuario��6   $	��250��6M   $��5q�6Y   6�   5      �� 5      $ 
Horizontal=�6   .+�5        $	 Key=�6*   $��Center=�65   ���#7070706P   G� 5      -   5         G�Name$ ContrasenaPasswordBox��5   a   $
 Contraseña��6   $	��250��6J   $��5q�6V   6�   5      �� 5      $ 
Horizontal=�6   $��25q�62   $��Center=�6>   $��40��6[   $	��230��6g   .+�5      �� -   5         ��Name$ IngresarButton��5      $��Acceder��61   $
��10,0q�6C   $
��Bold"�6o   
�������$��88��6�   �� 5      -   5        $ CancelarButton��5      $��20,0,0,0q�6Q   .��5       �� $ 
Horizontal=�6!   .+�5!      �� $��Cancelar��6    $
��Bold"�63   
�������6E   5"      5#      5$      5%      5&      5'      