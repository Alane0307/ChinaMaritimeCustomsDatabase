# -*- coding: utf-8 -*-
"""
Created on Fri Jan 11 00:22:54 2019

@author: hasee
"""

with open('InsertKeyWord02.sql', 'w') as file:
    file.write('USE ChinaMarinetime\n')
    file.write('GO\n')
    file.write('INSERT INTO KeyWord (CallNo, Keyword)\n')
    file.write('VALUES ')
    for i in range(0, 200):
        if i < 10:
            file.write('(\'F500'+str(i)+'\', \'None\'),\n')
        elif i < 100:
            file.write('(\'F50'+str(i)+'\', \'None\'),\n')
        else:
            file.write('(\'F5'+str(i)+'\', \'None\'),\n')
    file.write('GO')