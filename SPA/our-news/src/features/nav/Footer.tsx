import React from 'react'
import { Grid, List, Icon, Feed, Card, Container, Image } from 'semantic-ui-react'
import './Footer.css'


const Footer = () => {
    return (
        <Grid >
            <Grid.Row columns={3} className="topFooter">
                <Grid.Column style={{heigth: "300px", paddingLeft: "5%", marginTop: "2%"}} >
                    <Container style={{marginTop: "1%"}}>
                        <Image src="assets/images/logo/logo2.png"/>
                        <summary> Address: Dublin 15, Dublin, Ireland@</summary>
                        <summary> Phone: 1 3216541</summary>
                    </Container>
                    
                </Grid.Column>
                <Grid.Column style={{height: "280px"}}>
                    <Card fluid>
                        <Card.Content header="Most Viewed" as="h2" textAlign="center" />                 
                       
                        <Card.Content>
                        <Feed size="small">                            
                            <Feed.Event>
                                <Feed.Label image='assets/images/news/image2.jpg' style={{width: "60px"}}/>
                                <Feed.Content>
                                    <Feed.Date content='1 day ago' />
                                    <Feed.Summary>
                                    You added Jenny Hess to your coworker group.
                                    </Feed.Summary>
                                </Feed.Content>
                            </Feed.Event>
                           
                            <Feed.Event>
                                <Feed.Label image='assets/images/news/image1.jpg' style={{width: "60px"}} />
                                <Feed.Content>
                                    <Feed.Date content='3 days ago' />
                                    <Feed.Summary>
                                    You added Molly Malone as a friend.
                                    </Feed.Summary>
                                </Feed.Content>
                            </Feed.Event>

                            <Feed.Event>
                                <Feed.Label image='assets/images/news/image3.jpg' style={{width: "60px"}}/>
                                <Feed.Content>
                                    <Feed.Date content='4 days ago' />
                                    <Feed.Summary>
                                    You added Elliot Baker to your musicians group.
                                    </Feed.Summary>
                                </Feed.Content>
                            </Feed.Event>
                            <Feed.Event>
                                <Feed.Label image='assets/images/news/image4.jpg' style={{width: "60px"}}/>
                                <Feed.Content>
                                    <Feed.Date content='4 days ago' />
                                    <Feed.Summary>
                                    You added Elliot Baker to your musicians group.
                                    </Feed.Summary>
                                </Feed.Content>
                            </Feed.Event>
                        </Feed>
                        </Card.Content>
                    </Card>
                </Grid.Column>
                <Grid.Column>
                <Card fluid>
                    <Card.Content header="Category" as="h2" textAlign="left" />
                    <Card.Content>
                        <List>
                            <List.Item as='a' style={{marginTop: "1em"}}>
                                <Icon name='caret right' size="large" />
                                <List.Content>
                                    <List.Header as="h3">Business</List.Header>
                                </List.Content>
                            </List.Item>
                            <List.Item as='a' style={{marginTop: "1em"}}>
                                <Icon name='caret right' size="large"/>
                                <List.Content>
                                    <List.Header as="h3">Economy</List.Header>
                                </List.Content>
                            </List.Item>
                            <List.Item as='a' style={{marginTop: "1em"}}>
                                <Icon name='caret right'size="large" />
                                <List.Content>
                                    <List.Header as="h3">Politics</List.Header>
                                </List.Content>
                            </List.Item>
                            <List.Item as='a' style={{marginTop: "1em"}}>
                                <Icon name='caret right' size="large" />
                                <List.Content>
                                    <List.Header as="h3">World </List.Header>
                                </List.Content>
                            </List.Item>

                        </List>
                    </Card.Content>
                </Card>                  
                   
                </Grid.Column>
            </Grid.Row>
            <Grid.Row columns={3} style={{color: "#f4f3f3", height: "70px", backgroundColor: "#800f0f"}} >
                <Grid.Column width={6}>
                </Grid.Column>
                <Grid.Column width={5} verticalAlign="bottom">
                    <p>Copyrights 2020</p>
                </Grid.Column>
                <Grid.Column width={5} verticalAlign="bottom" >
                    <List floated='left' horizontal>
                        <List.Item href='#'>
                            © GitHub, Inc.
                        </List.Item>
                        <List.Item href='#'>Home</List.Item>
                        <List.Item href='#'>Terms</List.Item>
                        <List.Item href='#'>Privacy</List.Item>
                        <List.Item href='#'>Contact</List.Item>
                        <List.Item href='#'>About Us</List.Item>
                    </List>
                </Grid.Column>
            </Grid.Row>
        </Grid>
    )
}

export default Footer
