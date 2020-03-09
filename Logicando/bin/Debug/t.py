from tkinter import *

janela = Tk()

def criarJanela():
    janela.title('Tabela de IMCs -- Igor Santos')
    janela.geometry("750x750")
    janela.resizable(False, False)

def corBotao(valor):

    cor = ""

    #valor do imc < 18.5
    if valor <= 18.5:
        cor = "yellow"

    elif (valor > 18.5) and (valor <= 24.9):
        cor = "green"

    elif (valor > 24.9) and (valor <= 29.9):
        cor = "magenta"
        
    elif (valor > 29.9) and (valor <= 34.9):
        cor = "cyan"

    elif (valor > 34.9) and (valor <= 39.9):
        cor = "white"

    else:
        cor = "red"
 
    return cor

def indice():
    #cor Amarela
    btn1 = Button(text='..', background='yellow')
    btn1.place(x=580, y=200)

    lbl1 = Label(text='Abaixo do peso')
    lbl1.place(x=610, y=200)

    #cor Verde
    btn1 = Button(text='..', background='green')
    btn1.place(x=580, y=230)

    lbl1 = Label(text='Peso Normal')
    lbl1.place(x=610, y=230)

    #cor Magenta
    btn1 = Button(text='..', background='magenta')
    btn1.place(x=580, y=260)

    lbl1 = Label(text='Sobre Peso')
    lbl1.place(x=610, y=260)

    #cor Cyan
    btn1 = Button(text='..', background='cyan')
    btn1.place(x=580, y=290)

    lbl1 = Label(text='Obesidade Grau 1')
    lbl1.place(x=610, y=290)

    #cor Write
    btn1 = Button(text='..', background='white')
    btn1.place(x=580, y=320)

    lbl1 = Label(text='Obesidade Grau 2')
    lbl1.place(x=610, y=320)

    #cor Red
    btn1 = Button(text='..', background='red')
    btn1.place(x=580, y=350)

    lbl1 = Label(text='Obesidade Grau 3')
    lbl1.place(x=610, y=350)

def criarBtns(vIA, iA, vIP, iP):
    l = 0
    c = 0

    #definir Intervalos e Valores Iniciais
    valorInicialAltura = vIA
    intervalA = iA
    
    valorInicialPeso = vIP
    intervalP = iP
    
    for i in range(1, 20):
        for j in range(1, 12):
            #Calcular o valor
            valorBtn = (valorInicialPeso + (intervalP * i)) / ((valorInicialAltura + (intervalA * j)) ** 2)

            #com Base no ValorEscolher a Cor do Botao
            corBtn = corBotao(valorBtn)

            #Label de Indices
            #altura
            textoLabel = str( round(valorInicialAltura + (intervalA * j), 2) )
            lbl = Label(text = textoLabel)
            lbl.place(x = (50 + c), y = 45)

            #altura
            textoLabel2 = str( round(valorInicialPeso + (intervalP * i), 2) )
            lbl2 = Label(text = textoLabel2)
            lbl2.place(x = 15, y = (65 + l))
            
            #formatar valor para exibicao
            converterValor = str(valorBtn)
            if len(converterValor) == 4:
                #Acrescentar um espaço
                textoBtn = '{}{}'.format(round(valorBtn, 2), ' ')
                
                bt = Button(text = textoBtn, background = corBtn)
                bt.place(x = (50 + c), y = (65 + l))

            else:
                #Nao Acrescenta
                textoBtn = '{}'.format(round(valorBtn, 2))
                
                bt = Button(text = textoBtn, background = corBtn)
                bt.place(x = (50 + c), y = (65 + l))

            #somar 45 na distancia Horizontal
            c += 45

        #somar 35 na distancia vertical e zerar a posicao de c para voltar do inicio
        l += 35
        c = 0

def pergunta():
    #print(' ========================  Altura (m)  ======================== ')
    #valorInicialA = float(input(' ===> Digite o valor Inicial da Altura(m): '))
    #intervalA = float(input(' ===> Digite o Intervalo da Atura(m): '))

    #print(' \n========================  Peso (m)  ======================== ')
    #valorInicialP = float(input(' ===> Digite o Valor Inicial do Peso(Kg): '))
    #intervalP = float(input(' ===> Digite o Intervalo do Peso(Kg): '))

    criarBtns(1.60, 0.20, 60, 1)


criarJanela()
pergunta()
indice()
janela.mainloop()
