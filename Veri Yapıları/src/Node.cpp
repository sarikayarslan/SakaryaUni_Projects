/** 
* @file Node.cpp
* @description çift yönlü dairesel bağlı liste oluşturma, çaprazlama. 
* @course 1.ÖĞRETİM C GRUBU
* @assignment ÖDEV 1 
* @date 28.11.2020 
* @author ARSLANCAN SARIKAYA arslancan.sarikaya@ogr.sakarya.edu.tr 
*
**/


#include "Node.hpp"

	Node::Node() {
		this->data = 0;
		this->prev = NULL;
		this->next = NULL;
	}


	Node::Node(int data) {
		this->data = data;
		this->prev = NULL;
		this->next = NULL;
	}