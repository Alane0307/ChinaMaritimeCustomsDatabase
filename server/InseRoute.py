# -*- coding: utf-8 -*-
"""
Created on Tue Feb 12 19:35:11 2019

@author: liu
"""

from openpyxl import load_workbook

filename = 'route.xlsx'

workbook = load_workbook(filename)
sheets = workbook.get_sheet_names()
booksheet = workbook.get_sheet_by_name(sheets[0])

rows = booksheet.rows
columns = booksheet.columns
a = []
        
with open('InseRoute.txt', 'w') as f1:
    f1.write('USE ChinaMarinetime\n')
    f1.write('GO\n')
    f1.write('INSERT INTO FileRoute (FileNo, FileRoute, CallNo)\n')
    f1.write('VALUES ')
    for row in rows:
        f1.write('(\''+str(row[0].value)+'\', ')
        f1.write('N\''+str(row[1].value)+'\', ')
        f1.write('\''+str(row[2].value)+'\'),\n')
        
    f1.write('GO')