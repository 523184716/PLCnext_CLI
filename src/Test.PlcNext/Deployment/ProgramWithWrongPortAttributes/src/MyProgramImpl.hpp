#pragma once
#include "Arp/System/Core/Arp.h"
#include "Arp/Plc/Esm/ProgramBase.hpp"
#include "Arp/System/Commons/Logging.h"

namespace ProgramWithOneStructPort { namespace MyComponent {

using namespace Arp;
using namespace Arp::Plc::Esm;

//#program
//#component(MyComponent)
class MyProgram : public ProgramBase, private Loggable<MyProgram>
{
public: // typedefs

public: // construction/destruction
    MyProgram(const String& name);
    MyProgram(const MyProgram& arg) = delete;
    virtual ~MyProgram(void) = default;

public: // operators
    MyProgram&  operator=(const MyProgram& arg) = delete;

public: // properties

public: // operations
    void    Execute(void)override;

private: // fields
	//#port
	//#attributes(UnkownAttribute1|UnkownAttribute2)
	int32 examplePort = 3;
	//#port
	//#attributes(UnkownAttribute)
	int32 examplePortalt = 3;
};

///////////////////////////////////////////////////////////////////////////////
// inline methods of class ProgramBase

}} // end of namespace ProgramWithOneStructPort::MyComponent
