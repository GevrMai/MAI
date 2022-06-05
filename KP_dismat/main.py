from pyvis.network import Network
from tkinter import *

net = Network(height='100%', width='100%', bgcolor='#9fb0cc')


global NumberOfNodes        # количество вершин
Connections = set()         # множество - граф

# будут использоваться для ввода ребер графа
labels = []             # массив с эл-ми label
entries = []            # массив с полями для ввода

def Take_input():       # проверка ввода кол-ва вершин
    answer.config(text='')      # обновляем поле для вывода ошибки
    isOK = True                 # данные корректны
    try:
        str = UserInput.get("1.0", 'end-1c')       # считали ввод
        NumberOfNodes = int(str)                    # переводим в целое число
        if NumberOfNodes < 1:                      # не может быть меньше 1 вершины
            isOK = False
    except:
        isOK = False

    if isOK == False:
        answer.config(text="Введено некорректное значение")
    else:                                                       # данные корректны
        EnterNumOfNodes.destroy()                               # закрываем окно
        EnterGraphInfo = Tk()                                   # новое окно
        EnterGraphInfo.title("Введите ребра графа")
        EnterGraphInfo.geometry('500x500')
        for i in range(NumberOfNodes):                          # создаются поля для ввода ребер
            n = len(entries)
            label = Label(EnterGraphInfo, text=f'Вершина {n+1} соединена с вершинами:')
            label.grid(row=n+1, column=0)
            labels.append(label)
            entry = Entry(EnterGraphInfo)
            entry.grid(row=n+1, column=1)
            entries.append(entry)
        Confirm = Button(EnterGraphInfo, height=2,
                         width=20,
                         text="Подтвердить",
                         command=lambda: Check_Input(EnterGraphInfo))
        Confirm.grid()
        EnterGraphInfo.mainloop()

def Check_Input(EnterGraphInfo):            # проверка ввода ребер
    isOK = True
    for i in range(len(entries)):
        try:
            userInput = str(entries[i].get())
            arrayInput = userInput.split("/")
            print(arrayInput)
            for node in arrayInput:
                if node != "" and int(node) < 0:
                    isOK = False
        except:
            isOK = False
    if isOK:                                # заносим данные в Connections
        for i in range(len(entries)):
            userInput = str(entries[i].get())
            arrayInput = userInput.split("/")
            for node in arrayInput:
                if node != "":
                    Connections.add((i+1, int(node)))
                else:
                    Connections.add((i + 1, node))
        EnterGraphInfo.destroy()                # закрываем окно


EnterNumOfNodes = Tk()                      # начальное окно
EnterNumOfNodes.title("Количество вершин")
EnterNumOfNodes.resizable(False, False)
EnterNumOfNodes.geometry('300x300')
numOfNodes = Label(text="Введите количество вершин графа")
answer = Label(text = '')
UserInput = Text(EnterNumOfNodes, height=2,
                width=25,
                bg="light yellow")
Display = Button(EnterNumOfNodes, height=2,
                 width=20,
                 text="Подтвердить",
                 command=lambda: Take_input())          # вызов функции при нажатии на кнопку
numOfNodes.pack()
UserInput.pack()
Display.pack()
answer.pack()
EnterNumOfNodes.mainloop()

VisitedNodes = []                       # глобально пройденные вершины в DFS
VisitedDFS = [0] * len(entries)         # массив с данными о компонентах связности
def DFS(graph, node, VisitedNodes, dfsVisited):          # проход в глубину
    if node not in VisitedNodes:
        VisitedNodes.append(node)
        dfsVisited.append(node)
        for k in graph:
            if node == k[0]:
                DFS(graph, k[1], VisitedNodes,dfsVisited)
    return dfsVisited

j = 1                                   # номер компонента связности
while 0 in VisitedDFS:                  # пока есть непосещенная вершина
    for i in range(len(VisitedDFS)):
        if VisitedDFS[i] == 0:
            dfsVisited = []                                     # пройденные вершины за 1 вызов DFS
            mas = DFS(Connections, i+1, VisitedNodes, dfsVisited)
            for z in range(len(mas)):
                if mas[z] != '':
                    VisitedDFS[int(mas[z]) - 1] = j          # присваиваем значение связности
            j += 1

print(VisitedDFS)
print(Connections)


for i in range(len(entries)):                   # добавление вершин в граф. цвет ставится в зави-ти от связности
    if VisitedDFS[i] == 1:
        net.add_node(i+1, label=str(VisitedNodes[i]), color='black')
    elif VisitedDFS[i] == 2:
        net.add_node(i+1, label=str(VisitedNodes[i]), color='green')
    elif VisitedDFS[i] == 3:
        net.add_node(i+1, label=str(VisitedNodes[i]), color='deepskyblue')
    elif VisitedDFS[i] == 4:
        net.add_node(i+1, label=str(VisitedNodes[i]), color='white')
    elif VisitedDFS[i] == 5:
        net.add_node(i+1, label=str(VisitedNodes[i]), color='red')
    elif VisitedDFS[i] == 6:
        net.add_node(i+1, label=str(VisitedNodes[i]), color='sienna')
    elif VisitedDFS[i] == 7:
        net.add_node(i+1, label=str(VisitedNodes[i]), color='purple')
    elif VisitedDFS[i] == 8:
        net.add_node(i+1, label=str(VisitedNodes[i]), color='pink')
    elif VisitedDFS[i] == 9:
        net.add_node(i+1, label=str(VisitedNodes[i]), color='orange')
    elif VisitedDFS[i] == 10:
        net.add_node(i+1, label=str(VisitedNodes[i]), color='dimgray')
    elif VisitedDFS[i] == 11:
        net.add_node(i + 1, label=str(VisitedNodes[i]), color='indigo')
    elif VisitedDFS[i] == 12:
        net.add_node(i+1, label=str(VisitedNodes[i]), color='dodgerblue')
    elif VisitedDFS[i] == 13:
        net.add_node(i+1, label=str(VisitedNodes[i]), color='teal')
    elif VisitedDFS[i] == 14:
        net.add_node(i+1, label=str(VisitedNodes[i]), color='olive')
    elif VisitedDFS[i] == 15:
        net.add_node(i+1, label=str(VisitedNodes[i]), color='navy')


for k in Connections:           # добавляем ребра
    if k[1] != '':
        net.add_edge(k[0], k[1], weight=5.0)

net.show("graph.html")