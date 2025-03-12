"""
Tic Tac Toe Player
"""

import math
import copy

X = "X"
O = "O"
EMPTY = None


def initial_state():
    """
    Returns starting state of the board.
    """
    return [[EMPTY, EMPTY, EMPTY],
            [EMPTY, EMPTY, EMPTY],
            [EMPTY, EMPTY, EMPTY]]


def player(board):
    """
    Returns player who has the next turn on a board.
    """
    icountX, icountO = 0,0;    
    for row in board:
        for element in row:
            if element == "X":
                icountX += 1
            elif element == "O":
                icountO += 1

    if (icountO == 0) and (icountX == 0):
        return "X"
    elif icountX > icountO:
        return "O"
    else:
        return "X" if icountO > icountX else "O"


def actions(board):
    """
    Returns set of all possible actions (i, j) available on the board.
    """
    actions = []
    for i in range(0, 3):
        for j in range(0, 3):
            if board[i][j] == None:
                actions.append((i, j))
    return actions

def result(board, action):
    """
    Returns the board that results from making move (i, j) on the board.
    """
    newBoard = copy.deepcopy(board);
    if action not in actions(board):
        raise ValueError
    newBoard[action[0]][action[1]] = player(board)
    return newBoard


def winner(board):
    """
    Returns the winner of the game, if there is one.
    """
    #diagonals
    if (board[0][0] == board[1][1] == board[2][2] and board[0][0] != None) or (board[0][2] == board[1][1] == board[2][0] and board[0][2] != None):
        return board[1][1]
    #horizontals and verticals
    for i in range(0, 3):
        stemp = ""
        stemp2 = ""
        for j in range(0, 3):
            #horizontal
            stemp += str(board[i][j])   
            #vertical
            stemp2 += str(board[j][i])          
        if stemp == "XXX" or stemp2 == "XXX":
            return "X"
        elif stemp == "OOO" or stemp2 == "OOO":
            return "O"
    #no winner
    return None       
    
            


def terminal(board):
    """
    Returns True if game is over, False otherwise.
    """    
    icountCells = 0
    if winner(board) != None:
        return True
    else:
        for i in range(0, 3):
            for j in range(0, 3):
                if board[i][j] == None:
                    return False
                else:
                    icountCells += 1
    if icountCells == 9:
        return True


def utility(board):
    """
    Returns 1 if X has won the game, -1 if O has won, 0 otherwise.
    """
    if winner(board) == "X":
        return 1
    elif winner(board) == "O":
        return -1
    return 0


def minimax(board):
    """
    Returns the optimal action for the current player on the board.
    """
    if terminal(board):
        return None
    else:
        if player(board) == 'X':
            return maxValue(board)
        else:
            return maxValue(board)

            
def minValue(board):
    v = 1
    for action in actions(board):
        v = min(v, max(result(board, action)))
    return v

def maxValue(board):
    v = -1
    for action in actions(board):
        v = max(v, min(result(board, action)))
    return v      