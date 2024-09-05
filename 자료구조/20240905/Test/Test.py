import datetime
import time


def test(a,b) :
    if a > 100 :
        c=1
    else :
        c=0
   
    print('b =' , str(b))

    if b > 250:
        d=1
    else:
        d=0


    return c, d


a= 150
b= 250.55


while True :
      value = test(a,b)
      tm= datetime.datetime.now()
      print(value, tm)
      time.sleep(3)






