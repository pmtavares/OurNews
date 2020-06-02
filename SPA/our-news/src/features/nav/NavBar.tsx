import React, { useState } from 'react'
import { Menu, Container } from 'semantic-ui-react'
import './NavBar.css'

const NavBar = () => {
  const [activeItem, setActiveItem] = useState('home');
  const handleItemClick = (e:any, {name}:any) => {
    setActiveItem(name);
  }


    return (      
        <Menu pointing secondary >
        <Container>
          <Menu.Item
            name='home'
            active={activeItem === 'home'}
            onClick={(e, item) => {
                handleItemClick(e, item)
              }}
          />
           <Menu.Item
            name='economy'
            active={activeItem === 'economy'}
            onClick={(e, item) => handleItemClick(e,item)}
          />
           <Menu.Item
            name='business'
            active={activeItem === 'business'}
            onClick={(e, item) => handleItemClick(e,item)}
          />
            <Menu.Item
            name='sports'
            active={activeItem === 'sports'}
            onClick={(e, item) => handleItemClick(e,item)}
          />
          <Menu.Item
            name='about'
            active={activeItem === 'about'}
            onClick={(e, item) => handleItemClick(e,item)}
          />
          <Menu.Item
            name='contact'
            active={activeItem === 'contact'}
            onClick={(e, item) => handleItemClick(e,item)}
          />
          </Container>
        </Menu>

    )
}

export default NavBar
