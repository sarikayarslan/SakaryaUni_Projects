/** 
* @file List.hpp 
* @description çift yönlü dairesel bağlı liste oluşturma, çaprazlama. 
* @course 1.ÖĞRETİM C GRUBU
* @assignment ÖDEV 1 
* @date 28.11.2020 
* @author ARSLANCAN SARIKAYA arslancan.sarikaya@ogr.sakarya.edu.tr 
*
**/
#ifndef LIST_HPP
#define LIST_HPP

#include <iostream>
#include <sstream>
#include <fstream>
#include"Node.hpp"
using namespace std;
class List {
public:
	Node* ortaDugum;
	int listeboyutu;
};
#endif