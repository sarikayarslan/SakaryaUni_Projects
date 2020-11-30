/** 
* @file Node.hpp 
* @description çift yönlü dairesel bağlı liste oluşturma, çaprazlama. 
* @course 1.ÖĞRETİM C GRUBU
* @assignment ÖDEV 1 
* @date 28.11.2020 
* @author ARSLANCAN SARIKAYA arslancan.sarikaya@ogr.sakarya.edu.tr 
*
**/
#ifndef NODE_HPP
#define NODE_HPP
#include <iostream>
#include <sstream>
#include <fstream>
using namespace std;
class Node {
public:
	int data;
	Node* prev;
	Node* next;

	Node();
	Node(int);
};

#endif