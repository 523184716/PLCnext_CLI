﻿#include "DoublePortDeclarationComponent.hpp"
#include "Arp/Plc/Commons/Esm/ProgramComponentBase.hpp"

namespace DoublePortDeclaration
{

void DoublePortDeclarationComponent::Initialize()
{
    // never remove next line
    ProgramComponentBase::Initialize();

    // subscribe events from the event system (Nm) here
}

void DoublePortDeclarationComponent::LoadConfig()
{
    // load project config here
}

void DoublePortDeclarationComponent::SetupConfig()
{
    // never remove next line
    ProgramComponentBase::SetupConfig();

    // setup project config here
}

void DoublePortDeclarationComponent::ResetConfig()
{
    // never remove next line
    ProgramComponentBase::ResetConfig();

    // implement this inverse to SetupConfig() and LoadConfig()
}

} // end of namespace DoublePortDeclaration
