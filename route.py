# -*- coding: utf-8 -*-
"""
Created on Tue Feb 12 14:36:11 2019

@author: hasee
"""

import os

g = os.walk(r"F:\CMC\TIFF")

with open("F:/CMC/server/route_test.txt", 'w') as file:
    for path, dir_list, file_list in g:
        for file_name in file_list:
            file.write(os.path.join(path, file_name)+'\n')