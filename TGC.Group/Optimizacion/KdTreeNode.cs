﻿using TGC.Core.SceneLoader;

namespace TGC.Group.Optimizacion
{
    /// <summary>
    ///     Nodo del árbol KdTree
    /// </summary>
    internal class KdTreeNode
    {
        public KdTreeNode[] children;
        public TgcMesh[] models;

        //Corte realizado
        public float xCut;

        public float yCut;
        public float zCut;

        public bool isLeaf()
        {
            return children == null;
        }
    }
}