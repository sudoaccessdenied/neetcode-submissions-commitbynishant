class Solution {
    public boolean isValidSudoku(char[][] board) {
        boolean[][] seenRows = new boolean[10][10];
        boolean[][] seenBoxs = new boolean[10][10];
        boolean[][] seenCols = new boolean[10][10];
        for(int i =0;i< 9;i++){
            for(int j =0;j<9;j++){
                char val = board[i][j];
                if(val =='.') continue;
                int num = val-'0';
                int boxIndex = (i/3)*3 + j/3;
                if(seenRows[i][num]|| seenCols[j][num]|| seenBoxs[boxIndex][num]){
                    return false;
                }
                seenRows[i][num]=true;
                seenCols[j][num]=true;
                seenBoxs[boxIndex][num]=true;
            }
        }
        return true;

    }
}
