#include <iostream>
#include <vector>
class MyMatrix
{
    private:
        std::vector<std::vector<double>> matrix;

        static bool is_rectangular(const std::vector<std::vector<double>>& jaggedArray) {
        size_t cols = jaggedArray[0].size();
        for (const auto& row : jaggedArray) {
            if (row.size() != cols) return false;
        }
        return true;
    }

    public:

    //конструктор копіювання
        MyMatrix(const MyMatrix& other_matrix)
        {
            matrix = other_matrix.matrix;
        }

    //конструктор матритсі

        MyMatrix(const std::vector<std::vector<double>>& array) 
        {
            if (!is_rectangular(array)) {
                throw std::invalid_argument("Input array must be rectangular.");
            }
            matrix = array;
        }
        


};