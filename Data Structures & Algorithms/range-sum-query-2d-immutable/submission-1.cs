public class NumMatrix {

    public int[][] sum ;
    public NumMatrix(int[][] matrix) {
        sum = new int[matrix.Length][];
        for(int i =0;i< matrix.Length;i++){
            sum[i] = new int[matrix[i].Length];
        }
        sum[0][0] = matrix[0][0];
        for(int i =1;i< matrix[0].Length;i++){
            sum[0][i]= sum[0][i-1]+ matrix[0][i];
        }
        for(int i =1;i< matrix.Length;i++){
            sum[i][0]= sum[i-1][0]+ matrix[i][0];
        }

        for(int i = 1;i< matrix.Length;i++){
            for(int j = 1;j< matrix[i].Length;j++){
                sum[i][j]= sum[i][j-1]+sum[i-1][j]-sum[i-1][j-1]+matrix[i][j];
            }
        }
        
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {

        var c1 = sum[row2][col2] ;
        var c2 = row1 !=0? sum[row1-1][col2]:0;
        var c3 = col1!=0?sum[row2][col1-1]:0;
        var c4 = row1!=0 && col1!=0 ? sum[row1-1][col1-1] : 0;
        var  totalSum = c1 - c2 - c3 + c4;
        return totalSum;
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */