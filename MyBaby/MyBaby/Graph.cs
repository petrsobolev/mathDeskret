﻿using System.Collections.Generic;
using System;
using System.Text;
namespace MyBaby
{
	class Graph
	{
		private List<Node> nods = new List<Node>();
		public List<Node> Nods{
			get{
				return nods;
			}
			set{
				new List<Node>();
				nods = value;
			}
		}
		private List<Edge> edges = new List<Edge>();
		public List<Edge> Edges{
			get{
				return edges;
			}
			set{
				new List<Edge>();
				edges = value;
			}
		}
		public Graph()
		{
			new List<Node>();
			new List<Edge>();

		}
		public void addNode(int val)
		{
			
			Nods.Add(new Node(val));
		}
		public void addEdge(Node start, Node finish)
		{
			Edges.Add(new Edge(start, finish));
		}
		
	}
}
