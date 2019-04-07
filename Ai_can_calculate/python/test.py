import pdb
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
    word = word.replace("x", "*")
    word = word.replace("X", "*")
    #Divide
    word = word.replace("divide by", "/")
    #word = word.replace("÷", "/")
    word = word.replace("over", "/")
    word = word.replace("divide", "/")
    #pdb.set_trace()
    word = word.replace(",", "")
    word = word.replace(" ", "")
    answer = eval(word)
    try:
        return str(answer)
    except:
        return "error"

print(StringEval("5 * 5"))
