def StringEval(word):
    #Plus
    word = word.replace("plus", "+")
    word = word.replace("add", "+")
    #Minus
    word = word.replace("minus", "-")
    word = word.replace("subtract", "-")
    word = word.replace("take away", "-")
    #Multiply
    word = word.replace("multiply", "*")
    word = word.replace("times", "*")
    #Divide
    word = word.replace("divide by", "/")
    word = word.replace("over", "/")
    word = word.replace("divide", "/")
    try:
        return eval(word)
    except:
        return "error"
