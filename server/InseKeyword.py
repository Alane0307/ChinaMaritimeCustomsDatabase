# -*- coding: utf-8 -*-
"""
Created on Tue Feb 12 22:22:55 2019

@author: hasee
"""

from openpyxl import load_workbook

filename = u'近中洋書.xlsx'

workbook = load_workbook(filename)
sheets = workbook.get_sheet_names()
booksheet = workbook.get_sheet_by_name(sheets[0])

rows = booksheet.rows
columns = booksheet.columns
a = []
        
with open('InseKey.txt', 'w') as f1:
    f1.write('USE ChinaMarinetime\n')
    f1.write('GO\n')
    f1.write('INSERT INTO KeyWord (CallNo, Keyword)\n')
    f1.write('VALUES ')
    for row in rows:
        f1.write('(\''+str(row[0].value)+'\', \'None\'),\n')
        
    f1.write('GO')