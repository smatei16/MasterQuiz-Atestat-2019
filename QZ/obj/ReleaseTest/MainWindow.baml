   M S B A M L   `   `   `  ���� =  9QZ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:QZQZ      QZ.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     "localclr-namespace:QZ     $	��600��$
��1024��  � 
ResizeMode$  NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=�.��� -   $��DefaultGrid��$y�Visible=� � ColumnDefinitions �� $	��200 ��� $��* � � RowDefinitions �� $��30 ��� $��* �.+�� -   $��BarGrid��$��2�����	#FF0FB875 �� $
��118* ��� $��5* ��� $��5* �.+��� -   $��CloseButton��$��2�����	#FF0FB875$
��Left=�$��40����Z� .��� .+��� -   $��
CloseImage��$��Images/Close.png��$��26��$	��Top=��� -   $��MinimizeButton��$��1�����	#FF0FB875$
��Left=�$��40����Z� .��� .+��� -   $��MinimizeImage��$��Images/Minimize.png��$��26��$	��Top=�� -   $��DashboardGrid��$��1��$��1�����	#FFCFCFCF �� $��* ��� $	��100 ��� $��* � �� �� .+�� -   $��NewQuestionsAdded��$��0�� �� $
��143* ��� $	��67* ��� $	��24* �.+��� -	   $ ��NewQuestionsAddedRectangle��$	��190��$��20,22,20,22.666q�
������� �� RadiusX$ 10�� �� RadiusY$ 10��$��3��� $��0��$��0,0,0,0.333q� �� $��2* ��� $	��11* �.+��� -
   $��AddedQuestionsText��$��1��$
��Gugi)�$��90(�$��Center=�$��Center=�$��2��123� $��1��.+��� -   $��NewQuestionAddedTextText��$��	Righteous)�$��10q�$��20(�$��Center=�$��Center=�New Questions Added� -   $��ResolvedQuizes��$��1�� �� $
��143* ��� $	��67* ��� $	��24* �.+��� -   $��ResolvedQuizesRectangle��$	��190��$��20q�
�������$ 10��$ 10��$��3��� $��0��$��0,0,0,0.333q� �� $��2* ��� $	��11* �.+��� -   $��numberOfSolvedQuizes��$��1��$��./Resources/FONTS/#Gugi)�$��90(�$��Center=�$��Center=�$��2��456� $��1��.+��� -   $��numberOfSolvedQuizesText��$��	Righteous)�$��10q�$��20(�$��Center=�$��Center=�Solved Quizes� -   $��StartQuizButton��$��1��$��0��$��2��.+��� -   $��StartButton��
�����@�$	��500��$��10q�.���� -   $��StartButtonText��$��Center=�$��START A NEW QUIZ��$
��Gugi)�$��30(�� -   $��SuccessfulQuizes��$��2��$��2��.+��� -   $��SuccessfulQuizesRectangle��$	��190��$��20q�
�������$ 10��$ 10���� -   $��Procent��$��DefaultPercent��$��20q�$
��Gugi)�$��70(�$��Center=�$��Center=�� -   $��QuizEditorGrid��$��1��$��1�����	#FFCFCFCF$y�Hidden=� �� $��* ��� $	��130 ��� $	��130 ��� $��80 � �� $��* ��� $��* �.+�� -   $��Question��$��2��.+��� -   $��qBoxRectangle��
�������$��40q�$ 10��$ 10���� -   $
��qBox��$
��Gugi)�$��40q�$��Enter a new question��$��48(�$��Center=�$��Center=�$	��744��$	��150�� �� TextAlignment$ Center=�$��Center=� �� SelectionBrush �	#FF1379BC��Z� ��Z� .��� -   $��Answer1��$��1��.+��� -   $��Answer1Rectangle��
�������$��10q�$ 10��$ 10���� -   $��
AnswerBox1��$
��Gugi)�$��Enter correct answer��$��30(�$��Center=�$��Center=�$	��400��$	��110��$ Center=�$��Center=���Z� ��Z� � -   $��Answer2��$��2��.+��� -   $��Answer2Rectangle��
�������$��10q�$ 10��$ 10���� -   $��
AnswerBox2��$
��Gugi)�$��Enter wrong answer��$��30(�$��Center=�$��Center=�$	��400��$	��110��$ Center=�$��Center=���Z� ��Z� � -    $��Answer3��$��1��$��1��.+��� -!   $��Answer3Rectangle��
�������$��10q�$ 10��$ 10���� -"   $��
AnswerBox3��$
��Gugi)�$��Enter wrong answer��$��30(�$��Center=�$��Center=�$	��400��$	��110��$ Center=�$��Center=���Z� ��Z� � -#   $��Answer4��$��2��$��1��.+��� -$   $��Answer4Rectangle��
�������$��10q�$ 10��$ 10���� -%   $��
AnswerBox4��$
��Gugi)�$��Enter wrong answer��$��30(�$��Center=�$��Center=�$	��400��$	��110��$ Center=�$��Center=���Z� ��Z� � $��4��$��2��.+��� -&   $��InsertQuestionButton��$��10q�
�����@�$	��400����Z� .���� -'   $��InsertQuestionButtonText��$��Insert Question��$
��Gugi)�$��40(�$��10q�$��Center=�$��Center=�� -(   $��SettingsGrid��$��1��$��1�����	#FFCFCFCF$y�Hidden=� �� $��80 ��� $��80 ��� $��* �.+�� -)   $��ResetProgressGrid��.+��� -*   $��ResetProgressButton��$��10q�$	��300��
����ح�.��� .+��� -+   $��ResetProgressButtonText��$��Reset Progress��$��	Comfortaa)�$��30(�� -,   $��NightModeGrid��$��1��.+��� --   $��NightModeButton��$��10q�$	��300��
����ح�.���� -.   $��NightModeButtonText��$��
Night Mode��$��	Comfortaa)�$��30(�� -/   $��QuestionGrid��$��1��$��1�����	#FFCFCFCF$y�Hidden=� �� $	��100 ��� $��* ��� $	��150 ��� $	��150 �.+��  �� $	��250 ��� $��* ��� $	��250 �.+�� -0   $��QuestionNumberGrid�� �� $	��19* ��� $	��61* ��� $	��20* �.+�� $��1��.+��� -1   $��QuestionNumberRectangle��
�������$��5q�$ 10��$ 10��$��1��$	��150���� -2   $��QuestionNumberText��$
��Gugi)�$��40(�$��3��$��Center=�$��Center=�1/10� -3   $��TimeLeftGrid��$��2�� �� $	��19* ��� $	��61* ��� $	��20* �.+�� $��1��.+��� -4   $��TimeLeftRectangle��
�������$��5q�$ 10��$ 10��$	��200���� -5   $��	TimerText��$
��Gugi)�$��40(�$��3��$��Center=�$��Center=�$��20,0,0,0q��� -6   $��
TimerImage��$��Images/timer.png��$
��Left=�$��
35,15,0,15q�� $��1��.+��� -7   $��CurrentQuestionRectangle��
�������$��10q�$ 10��$ 10���� -8   $��CurrentQuestionText��$��10q�$
��Gugi)�$��20(�$��Center=�$��Center=�$
��Auto��$
��Wrap=�Default Question� $��2�� �� $
��206* ��� $
��206* �.+�� .+��� -9   $��Answer11Rectangle��
�������$��10q�$ 10��$ 10���� -:   $��Answer1Button��$��10q�
������ ��Z� .���� -;   $��Answer1Text��$��10q�$
��Gugi)�$��20(�$��Center=�$��Center=�$
��Wrap=�Default Answer� $��1��.+��� -<   $��Answer22Rectangle��
�������$��10q�$ 10��$ 10���� -=   $��Answer2Button��$��10q�
������ ��Z� .���� ->   $��Answer2Text��$��10q�$
��Gugi)�$��20(�$��Center=�$��Center=�$
��Wrap=�Default Answer� $��3�� �� $
��206* ��� $
��206* �.+�� .+��� -?   $��Answer33Rectangle��
�������$��10q�$ 10��$ 10���� -@   $��Answer3Button��$��10q�
������ ��Z� .���� -A   $��Answer3Text��$��10q�$
��Gugi)�$��20(�$��Center=�$��Center=�$
��Wrap=�Default Answer� $��1��.+��� -B   $��Answer44Rectangle��
�������$��10q�$ 10��$ 10���� -C   $��Answer4Button��$��10q�
������ ��Z� .��� .+��� -D   $��Answer4Text��$��10q�$
��Gugi)�$��20(�$��Center=�$��Center=�$��Default Answer��$
��Wrap=�� -E   $��CategorySelectionGrid��$��1��$��1�����	#FFCFCFCF$y�Hidden=� �� $��* ��� $��* ��� $��* � �� $	��100 ��� $��* ��� $��* ��� $��* �.+�� -F   $��PleaseSelectGrid��$��0��$��3��.+��� -G   $��PleaseSelectRectangle��
�������$��20q�$	��400��$ 10��$ 10���� -H   $��PleaseSelectText��$��Select A Category��$
��Gugi)�$��30(�$��Center=�$��Center=�� -I   $��Category1Grid��$��1��.+��� -J   $��10q�
������ $	��254��$	��136����Z� .���� $��Images/KnowledgeN.jpg��� -K   $��Category2Grid��$��1��$��1��.+��� -L   $��10q�
������ $	��254��$	��136����Z� .���� $��Images/FilmN.jpg��� -M   $��Category3Grid��$��1��$��2��.+��� -N   $��10q�
������ $	��254��$	��136����Z� .���� $��Images/MusicN.jpg��� -O   $��Category4Grid��$��2��.+��� -P   $��10q�
������ $	��254��$	��136����Z� .���� $��Images/GamesN.jpg��� -Q   $��Category5Grid��$��2��$��1��.+��� -R   $��10q�
������ $	��254��$	��136����Z� .���� $��Images/ComputersN.jpg��� -S   $��Category6Grid��$��2��$��2��.+��� -T   $��10q�
������ $	��254��$	��136����Z� .���� $��Images/MathN.jpg��� -U   $��Category7Grid��$��3��.+��� -V   $��10q�
������ $	��254��$	��136����Z� .���� $��Images/SportsN.jpg��� -W   $��Category8Grid��$��3��$��1��.+��� -X   $��10q�
������ $	��254��$	��136����Z� .���� $��Images/HistoryN.jpg��� -Y   $��Category9Grid��$��3��$��3��.+��� -Z   $��10q�
������ $	��254��$	��136����Z� .���� $��Images/PoliticsN.jpg��� -[   $��CongratsGrid��$��1��$��1�����	#FFCFCFCF$y�Hidden=� �� $
��140* ��� $
��140* ��� $
��291* �.+�� $��0��.+��� -\   $��CongratsRectangle��
�������$��20q�$ 10��$ 10���� -]   $��CongratsText��$��20q�$
��Gugi)�$��25(�$��Center=�$��Center=�� $��1��.+��� -^   $��ReturnToDashboardButton��
�����@�$��20q�$	��500��.���� -_   $��ReturnToDashboardText��$��Return to Dashboard��$
��Gugi)�$��40(�$��20q�� -`   $��EditCategory��$��1��$��1�����	#FFCFCFCF$y�Hidden=� �� $��* ��� $��* ��� $��* � �� $	��100 ��� $��* ��� $��* ��� $��* �.+�� -a   $��PleaseSelectGridEdit��$��0��$��3��.+��� -b   $��PleaseSelectEditRectangle��
�������$��20q�$	��400��$ 10��$ 10���� -c   $��PleaseSelectEditText��$��Select A Category��$
��Gugi)�$��30(�$��Center=�$��Center=�� -d   $��Category1GridEdit��$��1��.+��� -e   $��10q�
������ ��Z� .���� $��Images/KnowledgeN.jpg��� -f   $��Category2GridEdit��$��1��$��1��.+��� -g   $��10q�
������ ��Z� .���� $��Images/FilmN.jpg��� -h   $��Category3GridEdit��$��1��$��2��.+��� -i   $��10q�
������ ��Z� .���� $��Images/MusicN.jpg��� -j   $��Category4GridEdit��$��2��.+��� -k   $��10q�
������ ��Z� .���� $��Images/GamesN.jpg��� -l   $��Category5GridEdit��$��2��$��1��.+��� -m   $��10q�
������ ��Z� .���� $��Images/ComputersN.jpg��� -n   $��Category6GridEdit��$��2��$��2��.+��� -o   $��10q�
������ ��Z� .���� $��Images/MathN.jpg��� -p   $��Category7GridEdit��$��3��.+��� -q   $��10q�
������ ��Z� .���� $��Images/SportsN.jpg��� -r   $��Category8GridEdit��$��3��$��1��.+��� -s   $��10q�
������ ��Z� .���� $��Images/HistoryN.jpg��� -t   $��Category9GridEdit��$��3��$��3��.+��� -u   $��10q�
������ ��Z� .���� $��Images/PoliticsN.jpg��� -v   $��
ButtonGrid��$��1������ 	 �� EndPoint$	 0.5,1&�
 �� 
StartPoint$
 0.5,0&�.���  � Color$ 	LightGray�� � Offset$ 1Q�� $ 	#FFE6E6E6�� �� $	��100 ��� $��* � J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 20Q�   Color$ 	#FF3B3B3B��   RenderingBias$ Quality=�   ShadowDepth$ 1Q�.+�� -w   $��MQGrid�����	#FF58F2B5.+��� -x   $��MQText��$��MASTER QUIZ��$��Center=�$��Center=�$
��Gugi)����	#FF28903B$��28(��� $��1��.+��� -y   $��DashboardButton��$��10q����	#FF0FB875���	#FF0FB875$��50��.��� $	��150��.+��� -z   $��DashboardButtonText��$��Right=�$��	DASHBOARD��$
��Gugi)�$��Center=�$��0,0,20,0q��� -{   $��DashboardImage��$��Images/Dashboards.png��$
��Left=�$��35��$��35���� -|   $��QuizEditorButton��$��10q����	#FF0FB875���	#FF0FB875$��50��.��� $	��150��.+��� -}   $��QuizEditorButtonText��$��Right=�$��QUIZ EDITOR��$
��Gugi)�$��Center=�$��0,0,20,0q��� -~   $��QuizEditorImage��$��Images/Edit.png��$
��Left=�$��35��$��35��$��1,0,0,0q��� -   $��SettingsButton��$��10q����	#FF0FB875���	#FF0FB875$��50��.��� $	��150��.+��� -�   $��SettingsButtonText��$��Right=�$��SETTINGS��$
��Gugi)�$��Center=�$��0,0,35,0q��� -�   $��SettingsImage��$��Images/Settings.png��$
��Left=�$��35��$��35��