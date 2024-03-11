# -*- coding: utf-8 -*-
"""
Created on Tue Oct 09 17:24:02 2018

@author: hasee
"""
from openpyxl import load_workbook

filename = '近中洋書.xlsx'

workbook = load_workbook(filename)
sheets = workbook.get_sheet_names()
booksheet = workbook.get_sheet_by_name(sheets[0])

rows = booksheet.rows
columns = booksheet.columns
a = []
        
with open('InseTxt.txt', 'w') as f1:
    f1.write('USE ChinaMarinetime\n')
    f1.write('GO\n')
    f1.write('INSERT INTO PageInfo (CallNo, BookName, StartTime, EndTime, BookNo, StartPage, EndPage, Condition, Region, Title, Tag, Category, Remark1, Remark2, Composition)\n')
    f1.write('VALUES ')
    for row in rows:
        f1.write('(\''+str(row[0].value)+'\', ')
        f1.write('N\''+str(row[1].value)+'\', ')
        
        if not row[2].value:
            f1.write('NULL, ')
        else:
            f1.write(str(row[2].value)+', ')
        
        if not row[3].value:
            f1.write('NULL, ')
        else:
            f1.write(str(row[3].value)+', ')
        
        f1.write(str(row[4].value)+', ')
        
        if not row[5].value:
            f1.write('NULL, ')
        else:
            f1.write(str(row[5].value)+', ')
            
        if not row[6].value:
            f1.write('NULL, ')
        else:
            f1.write(str(row[6].value)+', ')
            
        if not row[7].value:
            f1.write('NULL, ')
        else:
            f1.write('N\''+row[7].value+'\', ')
            
        if not row[8].value:
            f1.write('NULL, ')
        else:
            f1.write('N\''+str(row[8].value)+'\', ')
            
        if not row[9].value:
            f1.write('NULL, ')
        else:
            f1.write('N\''+str(row[9].value)+'\', ')
            
        if not row[10].value:
            f1.write('NULL, ')
        else:
            f1.write('\''+str(row[10].value)+'\', ')
            
        if not row[11].value:
            f1.write('NULL, ')
        else:
            f1.write('N\''+row[11].value+'\', ')
            
        if not row[12].value:
            f1.write('NULL, ')
        else:
            f1.write('N\''+str(row[12].value)+'\', ')
            
        if not row[13].value:
            f1.write('NULL, ')
        else:
            f1.write('N\''+row[13].value+'\', ')
            
        if not row[14].value:
            f1.write('NULL),\n ')
        else:
            f1.write('N\''+row[14].value+'\'),\n')
        
    f1.write('GO')