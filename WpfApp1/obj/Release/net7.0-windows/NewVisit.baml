   M S B A M L   `   `   `  ���� B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1      WpfApp1.NewVisit   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     'localclr-namespace:WpfApp1     _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� Title$  NewVisit��.��� -    J� 	AllowDrop$
 true�����	#ffdadada.+��� $	��400��$��15q�
�������$��Center=� �� Padding$ 30q�$	��550�� �� CornerRadius$ 20�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 30Q�   Color$ 	LightGray��   ShadowDepth$ 0Q�._��� .+��� $#��Новое посещение��$��30(�$
��Bold"�$��0 0 0 20q�$
��Auto��$
��Auto��$
��Left=��� -   $��Right=�$��
Назад��   MaterialDesignFlatButton#��[  �� -    ��Name$ textBoxSearch��)  #MaterialDesignThemes.Wpf.HintAssist	   Hint$R	 LВведите имя или номер телефона для поиска�� % !MaterialDesignFloatingHintTextBox#��[ �� -   
 ��Name$
 listOfUsers������  �� 
TargetType" ��.�-   �� -   $ 
commentBox��$
 true��$	 Коментарий�� �� MinLines$ 3�� �� TextWrapping$
 Wrap=�#��[ � $	��400��$	��335��$��10q����� -   img�� �� ImageSource$? 9D:\OneDrive\Pictures\Saved Pictures\numeratsiya-zubov.jpg�� j� Stretch$ UniformToFill=�.+��� -    ��Name$	 t11��$
��Left=�$��
145,42,0,0q�$	��Top=��� -	   $	 t12��$
��Left=�$��
126,51,0,0q�$	��Top=��� -
   $	 t13��$
��Left=�$��
111,63,0,0q�$	��Top=��� -   $	 t14��$
��Left=�$��	99,79,0,0q�$	��Top=��� -   $	 t15��$
��Left=�$��	87,97,0,0q�$	��Top=��� -   $	 t16��$
��Left=�$��
80,121,0,0q�$	��Top=��� -   $	 t17��$
��Left=�$��
78,146,0,0q�$	��Top=��� -   $	 t18��$
��Left=�$��
78,174,0,0q�$	��Top=��� -   $	 t21��$
��Left=�$��
165,40,0,0q�$	��Top=��� -   $	 t22��$
��Left=�$��
188,49,0,0q�$	��Top=��� -   $	 t23��$
��Left=�$��
206,65,0,0q�$	��Top=��� -   $	 t24��$
��Left=�$��
215,83,0,0q�$	��Top=��� -   $	 t25��$
��Left=�$��228,101,0,0q�$	��Top=��� -   $	 t26��$
��Left=�$��237,121,0,0q�$	��Top=��� -   $	 t27��$
��Left=�$��237,146,0,0q�$	��Top=��� -   $	 t28��$
��Left=�$��237,174,0,0q�$	��Top=��� -   $	 t48��$
��Left=�$��
80,211,0,0q�$	��Top=��� -   $	 t47��$
��Left=�$��
80,238,0,0q�$	��Top=��� -   $	 t46��$
��Left=�$��
82,265,0,0q�$	��Top=��� -   $	 t45��$
��Left=�$��
94,283,0,0q�$	��Top=��� -   $	 t44��$
��Left=�$��108,309,0,0q�$	��Top=��� -   $	 t43��$
��Left=�$��120,327,0,0q�$	��Top=��� -   $	 t42��$
��Left=�$��138,332,0,0q�$	��Top=��� -   $	 t41��$
��Left=�$��151,334,0,0q�$	��Top=��� -    $	 t31��$
��Left=�$��165,334,0,0q�$	��Top=��� -!   $	 t32��$
��Left=�$��183,334,0,0q�$	��Top=��� -"   $	 t33��$
��Left=�$��201,325,0,0q�$	��Top=��� -#   $	 t34��$
��Left=�$��210,309,0,0q�$	��Top=��� -$   $	 t35��$
��Left=�$��224,283,0,0q�$	��Top=��� -%   $	 t36��$
��Left=�$��232,256,0,0q�$	��Top=��� -&   $	 t37��$
��Left=�$��235,233,0,0q�$	��Top=��� -'   $	 t38��$
��Left=�$��233,210,0,0q�$	��Top=��� -(    ��Name$ submit��$'��!Создать посещение��$
��0 20q�