def midPoint(X1,Y1,X2,Y2):  
    # calculate dx & dy  
    dx = X2 - X1  
    dy = Y2 - Y1  
  
    # initial value of decision parameter d  
    d = dy - (dx/2)  
    x = X1 
    y = Y1  
    
    print(x,",",y,"\n") 
    
    while (x < X2): 
        x=x+1
        
        if(d < 0): 
            d = d + dy  
        else: 
            d = d + (dy - dx)  
            y=y+1
        print(x,",",y,"\n")  
      
if __name__=='__main__': 
    X1 = 2
    Y1 = 2
    X2 = 8
    Y2 = 5
    midPoint(X1, Y1, X2, Y2)  
  
