#pragma once

// Standard headers
#include <assert.h>
#include <string>
#include <process.h>
#include <iostream>
#include <stdio.h>
#include <tchar.h>

// Windows specific headers
#if defined (_WIN32)
#include <WinSock2.h>
#include <windows.h>
#include <Ws2tcpip.h>
#endif 

// Generic
#include "Debug/DebugConsole.h"
#include "CommandOptions.h"

// Pathfinding
#include "Graph/SparseGraph.h"
#include "Graph/GraphAlgorithms.h"
#include "misc/utils.h"
#include "graph/GraphEdgeTypes.h"
#include "graph/GraphNodeTypes.h"

// Networking
#include "Networking.h"

// Gui
#undef min // use __min instead inside this source file
#undef max // use __max instead inside this source file

// BoyLib
#include "BoyLib/BoyUtil.h"
#include "BoyLib/Vector2.h"
#include "BoyLib/TGAlib.h"

// Boy
#include "Boy/Environment.h"
#include "Boy/Font.h"
#include "Boy/Game.h"
#include "Boy/Graphics.h"
#include "Boy/KeyboardListener.h"
#include "Boy/MouseListener.h"
#include "Boy/Mouse.h"
#include "Boy/ResourceManager.h"
#include "Boy/SoundPlayer.h"

// Battleboy
#include "Steering.h"
#include "Actor.h"
#include "Explosion.h"
#include "States.h"
#include "Unit.h"
#include "Map.h"
#include "BattleGui.h"
#include "BattleMap.h"
#include "BattleBoy.h"
#include "Controller.h"

