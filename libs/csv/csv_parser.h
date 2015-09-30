#ifndef __CSV_PARSER_H__
#define __CSV_PARSER_H__

#include <vector>

class csv_parser
{
protected:
	const char* buff;
	int length;
	std::vector<std::vector<int> > comma_positions;
public:
    // juse keep, never relase buff
    void keep(const char* buff, int length);
    // foreach line, get the right comma_positions, and push all comma position in it, until meet eof
    // position meaning the first char pos
    // safe_area for protecting parsing the wrong comma
    void parser(char delimit = ',', char safe_area = 0);
    int total_lines();
    int fields(int line_index);
    const char* get_value(int row, int colum, int& length);
};

#endif
