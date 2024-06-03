import java.util.*;
import java.io.*;
class Interview{

    public static void main(String[] args){
        int arr={12,15,18,30,79,100};
        int n=17;

        int index=0;

        for( int i=0;i<arr.length;i++){
            if(arr[i]>n)
            arr[i]=n;
            arr[i+1]=arr[i];
        }
        for(int i=0;i<arr.length;i++)
        {
            if(arr[i]==n)
            index=i;
        }

        System.out.println(index);


    }
}