   M S B A M L   `   `   `  ����I  EFractalPainter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:FractalPainterFractalPainter  5   	       FractalPainter.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:FractalPainter     5   	     � Title$  Fractal Painter 3000��5   	   $	��650��6&   $
��1100��63   $	��800��6@   $	��580��6O   .��5	      � .+�5
   
   (� $��	200,0,0,0q�6   $	��Top=�6%   $��Right=�6=    (� Stretch$
 Fill=�6Y   .��5      �� -   5         ��Name$ fractalCanvas��5      ���#212121$	��650��6A   $	��900��6P   $
}�true��6^   5      �� 5   
   -   5         ��Name$ pythagorasButton��5      $��40��6+   $	��180��67   $#��Дерево Пифагора��6C   $��	10,10,0,0q�5      $	��Top=�6$   $
��Left=�6<   �� 5   
   -   5        $ 
kochButton��5      $��40��6%   $	��180��61   $��Кривая Коха��6=   $��	10,60,0,0q�5      $	��Top=�6$   $
��Left=�6<   �� 5   
   -   5        $ carpetButton��5      $��40��6'   $	��180��63   $'��!Ковёр Серпинского��6?   $��
10,110,0,0q�5      $	��Top=�6%   $
��Left=�6=   �� 5   
   -   5        $ triangleButton��5      $��40��6)   $	��180��65   $3��-Треугольник Серпинского��6A   $��
10,160,0,0q�5      $	��Top=�6%   $
��Left=�6=   �� 5   
   -   5        $ cantorButton��5      $��40��6'   $	��180��63   $'��!Множество Кантора��6?   $��
10,210,0,0q�5      $	��Top=�6%   $
��Left=�6=   �� 5   
   -   5        $ 
saveButton��5      $��40��6%   $	��180��61   $/��)Сохранить изображение��6=   $
��Left=�5      $��Bottom=�6,   $��
10,0,0, 20q�6G   y�5      ��  �� ElementName$ recursionLabel�� �� Path$ 
Visibility�5   G   �� 5   
   -   5         ��Name$ pythagorasDepthSlider��5       � Value$ 6Q�62    � Minimum$ 1Q�6<   	 � Maximum$	 11Q�6H   
 �� SelectionStart$
 0Q�6U   $��30��5      $	��180��6    �� TickPlacement$ BottomRight=�6+    �� IsSnapToTickEnabled$
 True��6G    �� TickFrequency$ 1Q�5       �� IsSelectionRangeEnabled$
 True��6#    �� Orientation$ 
Horizontal=�6B   $y�Hidden=�6]   $
��Left=�5      $��Bottom=�6,   $��
10,0,0,224q�6G   5      �� 5    
   -	   5        $  pythagorasRightAngleSlider��5       $ 45Q�67   $ 0Q�6B   $	 90Q�6N   $
 0Q�6[   $��30��5!      $	��180��6   $
 None=�6+   $
 True��6@   $ 1Q�5"      $
 True��6#   $ 
Horizontal=�6B   $
��Left=�5$      $��Bottom=�6,   $��
10,0,0,164q�6G   y�5#      �� $ pythagorasDepthSlider��$ 
Visibility�5%      �� 5&   
   -
   5        $ pythagorasLeftAngleSlider��5&      $ 45Q�66   $ 0Q�6A   $	 90Q�6M   $
 0Q�6Z   $��30��5'      $	��180��6   $
 None=�6+   $
 True��6@   $ 1Q�5(      $
 True��6#   $ 
Horizontal=�6B   $
��Left=�5*      $��Bottom=�6,   $��10,0,0, 115q�6G   y�5)      �� $ pythagorasDepthSlider��$ 
Visibility�5+      �� 5,   
   -   5        $  pythagorasLengthRateSlider��5,      $	 0.7Q�67   $	 0.1Q�6C   $		 0.9Q�6Q   $
 0Q�6_   $��30��5-      $	��180��6   $ BottomRight=�6+   $
 True��6G   $	 0.1Q�5.      $
 True��6%   $ 
Horizontal=�6D   $
��Left=�50      $��Bottom=�6,   $��
10,0,0, 66q�6G   y�5/      �� $ pythagorasDepthSlider��$ 
Visibility�51      �� 53   
   -   5        $ kochDepthSlider��53      $ 4Q�6,   $ 1Q�66   $	 7Q�6B   $
 0Q�6N   $��30��54      $	��180��6   $
 Both=�6+   $
 True��6@   $ 1Q�55      $
 True��6#   $ 
Horizontal=�6B   $y�Hidden=�6]   $
��Left=�56      $��Bottom=�6,   $��
10,0,0,224q�6G   57      �� 59   
   -   5        $ carpetDepthSlider��59      $ 3Q�6.   $ 1Q�68   $	 6Q�6D   $
 0Q�6P   $��30��5:      $	��180��6   $
 Both=�6+   $
 True��6@   $ 1Q�5;      $
 True��6#   $ 
Horizontal=�6B   $y�Hidden=�6]   $
��Left=�5<      $��Bottom=�6,   $��
10,0,0,224q�6G   5=      �� 5?   
   -   5        $ triangleDepthSlider��5?      $ 4Q�60   $ 1Q�6:   $	 8Q�6F   $
 0Q�6R   $��30��5@      $	��180��6   $
 Both=�6+   $
 True��6@   $ 1Q�5A      $
 True��6#   $ 
Horizontal=�6B   $y�Hidden=�6]   $
��Left=�5B      $��Bottom=�6,   $��
10,0,0,224q�6G   5C      �� 5E   
   -   5        $ cantorDepthSlider��5E      $ 4Q�6.   $ 1Q�68   $	 10Q�6D   $
 0Q�6Q   $��30��5F      $	��180��6   $
 Both=�6+   $
 True��6@   $ 1Q�5G      $
 True��6#   $ 
Horizontal=�6B   $y�Hidden=�6]   $
��Left=�5H      $��Bottom=�6,   $��
10,0,0,224q�6G   5I      �� 5J   
   -   5        $ cantorDistanceSlider��5J      $ 30Q�61   $ 5Q�6<   $	 80Q�6H   $
 0Q�6U   $��30��5K      $	��180��6   $
 None=�6+   $
 True��6@   $ 1Q�5L      $
 True��6#   $ 
Horizontal=�6B   $
��Left=�5N      $��Bottom=�6,   $��
10,0,0,164q�6G   y�5M      �� $ cantorDepthSlider��$ 
Visibility�5O      �� 5Q   
   -   5         ��Name$ recursionLabel��5Q      $'��!Глубина Рекурсии: ��6*   $y�Hidden=�6G   $
��Left=�5R      $��Bottom=�6+   $��
10,0,0,255q�6F   �� 5S   
   -   5        $ pythagorasDepthLabel��5S      $
��bold"�5T      $
��Left=�5U      $��Bottom=�6+   $��130,0,0,255q�6F   ��5S   0   �� $ pythagorasDepthSlider��$ Value�y�5T   $   �� $ pythagorasDepthSlider��$ 
Visibility�5U   F   �� 5V   
   -   5        $ kochDepthLabel��5V      $
��bold"�5W      $
��Left=�5X      $��Bottom=�6+   $��130,0,0,255q�6F   ��5V   *   �� $ kochDepthSlider��$ Value�y�5W   $   �� $ kochDepthSlider��$ 
Visibility�5X   F   �� 5Y   
   -   5        $ carpetDepthLabel��5Y      $
��bold"�5Z      $
��Left=�5[      $��Bottom=�6+   $��130,0,0,255q�6F   ��5Y   ,   �� $ carpetDepthSlider��$ Value�y�5Z   $   �� $ carpetDepthSlider��$ 
Visibility�5[   F   �� 5\   
   -   5        $ triangleDepthLabel��5\      $
��bold"�5]      $
��Left=�5^      $��Bottom=�6+   $��130,0,0,255q�6F   ��5\   .   �� $ triangleDepthSlider��$ Value�y�5]   $   �� $ triangleDepthSlider��$ 
Visibility�5^   F   �� 5_   
   -   5        $ cantorDepthLabel��5_      $
��bold"�5`      $
��Left=�5a      $��Bottom=�6+   $��130,0,0,255q�6F   ��5_   ,   �� $ cantorDepthSlider��$ Value�y�5`   $   �� $ cantorDepthSlider��$ 
Visibility�5a   F   �� 5c   
   -   5        $ rightAngleLabel��5c      $��Правый угол: ��6+   $
��Left=�5e      $��Bottom=�6+   $��
10,0,0,195q�6F   y�5d      �� $ pythagorasDepthSlider��$ 
Visibility�5e   F   �� 5f   
   -   5        $ rightAngleValueLabel��5f      $
��bold"�5g      $
��Left=�5h      $��Bottom=�6+   $��130,0,0,195q�6F   ��5f   0   �� $  pythagorasRightAngleSlider��$ Value�y�5g   $   �� $ pythagorasDepthSlider��$ 
Visibility�5h   F   �� 5j   
   -   5        $ leftAngleLabel��5j      $��Левый угол: ��6*   $
��Left=�5l      $��Bottom=�6+   $��
10,0,0,145q�6F   y�5k      �� $ pythagorasDepthSlider��$ 
Visibility�5l   F   �� 5m   
   -   5        $ leftAngleValueLabel��5m      $
��bold"�5n      $
��Left=�5o      $��Bottom=�6+   $��130,0,0,145q�6F   ��5m   /   �� $ pythagorasLeftAngleSlider��$ Value�y�5n   $   �� $ pythagorasDepthSlider��$ 
Visibility�5o   F   �� 5q   
   -   5        $ lengthRateLabel��5q      $#��Отношение длин: ��6+   $
��Left=�5s      $��Bottom=�6+   $��
10,0,0,100q�6F   y�5r      �� $ pythagorasDepthSlider��$ 
Visibility�5s   F   �� 5t   
   -   5        $ lengthRateValueLabel��5t      $
��bold"�5u       �� ContentStringFormat$ {0:0.0}��6$   $
��Left=�5w      $��Bottom=�6+   $��130,0,0,100q�6F   ��5t   0   �� $  pythagorasLengthRateSlider��$ Value�y�5v      �� $ pythagorasDepthSlider��$ 
Visibility�5w   F   �� 5y   
   -   5        $ distanceLabel��5y      $��Расстояние: ��6)   $
��Left=�5{      $��Bottom=�6+   $��
10,0,0,197q�6G   y�5z      �� $ cantorDepthSlider��$ 
Visibility�5{   G   �� 5|   
   -   5        $ distanceValueLabel��5|      $
��bold"�5}      $
��Left=�5~      $��Bottom=�6+   $��130,0,0,197q�6G   ��5|   .   �� $ cantorDistanceSlider��$ Value�y�5}   $   �� $ cantorDepthSlider��$ 
Visibility�5~   G   5      5�      