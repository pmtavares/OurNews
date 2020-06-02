import React from 'react'
import { Grid, Image, Segment, Card, Icon, Header, Container } from 'semantic-ui-react'
import  './TopNews.style.css';

const TopNews = () => {
    return (
        <Grid>
            <Grid.Row columns={3}>
                <Grid.Column >                 
                    <Card  style={{width: "100%", overflowWrap: 'break-word'}}>
                            <Image src='assets/images/news/image5.jpg'  ui={false} 
                            className="card-image" href="#"/>
                            <Card.Content>
                            <Card.Header>Matthewrleprleprpelrpelrperleprleprleprleplreprleprleprlep</Card.Header>
                            <Card.Description>
                                Matthew is a musician living in Nashville.
                            </Card.Description>
                            </Card.Content>
                            <Card.Content extra>
                                <Icon name='user' />Username                  
                                <Icon name='clock' style={{marginLeft: "10%"}}/>
                                30/05/2020
                        
                            </Card.Content>
                    </Card>                                  
                </Grid.Column>
                <Grid.Column >
                    <Card style={{width: "100%", overflowWrap: 'break-word'}}>                        
                            <Image src='assets/images/news/image5.jpg' ui={false} 
                            className="card-image" href="#"/>                            
                            <Card.Content>
                            <Card.Header>Matthewrleprleprpelrpelrperleprleprleprleplreprleprleprlep</Card.Header>
                            <Card.Description>
                                Matthew is a musician living in Nashville.
                            </Card.Description>
                            </Card.Content>
                            <Card.Content extra>
                                <Icon name='user' />Username                  
                                <Icon name='clock' style={{marginLeft: "10%"}}/>
                                30/05/2020
                        
                            </Card.Content>
                    </Card>
                </Grid.Column>
                <Grid.Column className="gridColumn">      
                    <Card  style={{width: "100%", overflowWrap: 'break-word'}}>
                        <Image src='assets/images/news/image5.jpg' href="#" 
                            ui={false} className="card-image"
                         
                            />
                        <Card.Content>
                        <Card.Header>Matthewrleprleprpelrpelrperleprleprleprleplreprleprleprlep</Card.Header>
                        <Card.Description>
                            Matthew is a musician living in Nashville.
                        </Card.Description>
                        </Card.Content>
                        <Card.Content extra>
                            <Icon name='user' />Username                  
                            <Icon name='clock' style={{marginLeft: "10%"}}/>
                            30/05/2020
                    
                        </Card.Content>
                    </Card>
               
                </Grid.Column>
            </Grid.Row>
      </Grid>
    )
}



export default TopNews
