
#include "csv_parser.h"
#include <iostream>
#include <fstream>
#include <string>
#include <cstdlib>

#define INIT_SIZE 16

void csv_parser::keep(const char* buff, int length){
	this->buff = buff;
	this->length = length;
}


void csv_parser::parser(char delimit, char safe_area){
	const char* ite = buff;
	const char* eof = buff + length;
	int comma_size = INIT_SIZE;
	comma_positions.resize(comma_size);
	int row = 0;
	bool begin_of_line = true;	

	// if not end, read each line
	while(ite <= eof){
		if (comma_size <= row){
			comma_size *= 2;
			comma_positions.resize(comma_size);
		}
		std::vector<int>& cur_positions = comma_positions[row];

		if (begin_of_line){
			cur_positions.push_back((int)(ite - buff));
			begin_of_line = false;
			continue;
		}		

		// change line
		if (*ite == '\n'){
			begin_of_line = true;
			++row;
			++ite;
            // this positions belongs to last row
			cur_positions.push_back((int)(ite - buff));
			continue;
		}

#if 0
        // ignore for now
        char* next_ite = ite + 1;
        if (safe_area != 0 && *ite == safe_area && next_ite <= eof && *next_ite == delimit){

        }
#endif
        if (*ite == delimit){
            // offset by one fits the right char position as the offset
			cur_positions.push_back((int)(ite - buff + 1));
		}		

		++ite;
	}

	comma_positions.shrink_to_fit();

#if 1
	for (int i=comma_positions.size()-1; i>=0; --i){
		if (comma_positions[i].size() == 0){
			comma_positions.pop_back();
		} else {
			break;
		}
	}
#endif	
}

int csv_parser::total_lines(){
	return comma_positions.size();
}

int csv_parser::fields(int line_index){
	return comma_positions[line_index].size() - 1;
}
const char* csv_parser::get_value(int row, int colum, int& length){
	std::vector<int>& comma_row = comma_positions[row];
	int right_pos = comma_row[colum];// pass comma so plus one
	length = comma_row[colum + 1] - right_pos - 1;
	const char* ret_pos = right_pos + buff;
	return ret_pos;
}
